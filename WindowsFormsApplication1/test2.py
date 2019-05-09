#!/usr/bin/python3
# -*- coding: utf-8 -*-
from numpy import *
import sys
import pymssql

class CF:
    def __init__(self, problems, ratings, k=1, n=10):
        self.problems = problems
        self.ratings = ratings
        # 邻居个数
        self.k = k
        # 推荐个数
        self.n = n
        # 用户对课程的评分
        # 数据格式{'UserID：用户ID':[(ProblemID：课程ID,Rating：用户对课程的评分)]}
        self.userDict = {}
        # 对某课程评分的用户
        # 数据格式：{'ProblemID：课程ID',[UserID：用户ID]}
        # {'1',[1,2,3..],...}
        self.ItemUser = {}
        # 邻居的信息
        self.neighbors = []
        # 推荐列表
        self.recommandList = []
        self.cost = 0.0

    # 基于用户的推荐
    # 根据对课程的评分计算用户之间的相似度
    def recommendByUser(self, userId):
        self.formatRate()
        self.getNearestNeighbor(userId)
        self.getrecommandList(userId)
        # self.getPrecision(userId)
        for i in self.recommandList:
            print(i[1], end=',')

    # 获取推荐列表
    def getrecommandList(self, userId):
        self.recommandList = []
        # 建立推荐字典
        recommandDict = {}
        for neighbor in self.neighbors:
            problems = self.userDict[neighbor[1]]
            for problem in problems:
                if (problem[0] in recommandDict):
                    recommandDict[problem[0]] += neighbor[0]
                else:
                    recommandDict[problem[0]] = neighbor[0]

        # 建立推荐列表
        for key in recommandDict:
            self.recommandList.append([recommandDict[key], key])
        self.recommandList.sort(reverse=True)
        self.recommandList = self.recommandList[:self.n]

    # 将ratings转换为userDict和ItemUser
    def formatRate(self):
        self.userDict = {}
        self.ItemUser = {}
        for i in self.ratings:
            i = i[0].split('\t')
            # 评分最高为100 除以100 进行数据归一化
            temp = (i[1], float(i[2]) / 100)
            # 计算userDict {'1':[(1,5),(2,5)...],'2':[...]...}
            if (i[0] in self.userDict):
                self.userDict[i[0]].append(temp)
            else:
                self.userDict[i[0]] = [temp]
            # 计算ItemUser {'1',[1,2,3..],...}
            if (i[1] in self.ItemUser):
                self.ItemUser[i[1]].append(i[0])
            else:
                self.ItemUser[i[1]] = [i[0]]

    # 找到某用户的相邻用户
    def getNearestNeighbor(self, userId):
        neighbors = []
        self.neighbors = []
        # 获取userId评分的课程都有那些用户也评过分
        for i in self.userDict[userId]:
            for j in self.ItemUser[i[0]]:
                if (j != userId and j not in neighbors):
                    neighbors.append(j)
        # 计算这些用户与userId的相似度并排序
        for i in neighbors:
            dist = self.getCost(userId, i)
            self.neighbors.append([dist, i])
        # 排序默认是升序，reverse=True表示降序
        self.neighbors.sort(reverse=True)
        self.neighbors = self.neighbors[:self.k]

    # 格式化userDict数据
    def formatuserDict(self, userId, l):
        user = {}
        for i in self.userDict[userId]:
            user[i[0]] = [i[1], 0]
        for j in self.userDict[l]:
            if (j[0] not in user):
                user[j[0]] = [0, j[1]]
            else:
                user[j[0]][1] = j[1]
        return user

    # 计算余弦距离
    def getCost(self, userId, l):
        # 获取用户userId和l评分课程的并集
        # {'课程ID'：[userId的评分，l的评分]} 没有评分为0
        user = self.formatuserDict(userId, l)
        x = 0.0
        y = 0.0
        z = 0.0
        for k, v in user.items():
            x += float(v[0]) * float(v[0])
            y += float(v[1]) * float(v[1])
            z += float(v[0]) * float(v[1])
        if (z == 0.0):
            return 0
        return z / sqrt(x * y)

    # 推荐的准确率
    def getPrecision(self, userId):
        user = [i[0] for i in self.userDict[userId]]
        recommand = [i[1] for i in self.recommandList]
        count = 0.0
        if (len(user) >= len(recommand)):
            for i in recommand:
                if (i in user):
                    count += 1.0
            self.cost = count / len(recommand)
        else:
            for i in user:
                if (i in recommand):
                    count += 1.0
            self.cost = count / len(user)


# 获取数据
def readFile(filename):
    # files = open(filename, "r", encoding="utf-8")
    # utf-8读取会失败
    files = open(filename, "r", encoding="iso-8859-15")
    data = []
    for line in files.readlines():
        item = line.strip().split("::")
        data.append(item)
    return data


# -------------------------开始-------------------------------
# 创建数据库链接
db = pymssql.connect("localhost", "sa", "123456", "KOHLER")

# cursor()创建游标
cursor = db.cursor()

# 使用 execute() 方法执行 SQL 查询
cursor.execute("select c_id from classes")

# 使用 fetchall() 方法获取所有结果数据.
dataset = cursor.fetchall()

problems = []
# 遍历结果集构造课程数据
for row in dataset:
    problems.append([str(row[0])])

# print(problems)
ratings = []
cursor.execute("select uph.u_id, spl.c_id, upl.up_line_score from user_plan_lines upl,user_plan_header uph,study_plan_lines spl where uph.up_head_id = upl.up_head_id and upl.sp_line_id = spl.sp_line_id")

dataset = cursor.fetchall()

# 遍历结果集构造评分数据
for row in dataset:
    ratings.append([str(row[0]) + "\t" + str(row[1]) + "\t" + str(row[2])])

# print(ratings)
demo = CF(problems, ratings, k=10, n=3)#n为推荐列表中取出的数量
userId = sys.argv[1]
demo.recommendByUser(userId)
