using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using System.Data;
using NPOI.HPSF;
using NPOI.SS.Util;
using System.IO;
using System.Windows.Forms;
using NPOI.XSSF.UserModel;

namespace WindowsFormsApplication1
{
    class Excel
    {

        static IWorkbook hssfworkbook;
        //导出Excel文件
        public static void OutputExcel(DataTable dt, string fileAdd, string columnHeader = "")
        {
            //获取Excel
            var workbook = BuildWorkbook1(dt, columnHeader);
            //导出
            using (var fs = File.OpenWrite(fileAdd+ columnHeader+".xls"))
            {
                workbook.Write(fs);   //向打开的这个xls文件中写入mySheet表并保存。
                MessageBox.Show("生成成功");
            }
        }//DataTable数据源，fileAdd文件名，columnHeader，文章标题
        //设置Excel样板
        public static HSSFWorkbook BuildWorkbook1(DataTable dt, string columnHeader = "")
        {
            var workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet(string.IsNullOrWhiteSpace(dt.TableName) ? "Sheet1" : dt.TableName);

            #region 文件属性信息
            {
                var dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "KOHLER";
                workbook.DocumentSummaryInformation = dsi;

                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Author = "";
                si.ApplicationName = "";
                si.LastAuthor = "";
                si.Comments = "";
                si.Title = "";
                si.Subject = "";
                si.CreateDateTime = DateTime.Now;
                workbook.SummaryInformation = si;
            }
            #endregion

            var dateStyle = workbook.CreateCellStyle();
            var format = workbook.CreateDataFormat();
            dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

            //取得列宽
            var arrColWidth = new int[dt.Columns.Count];            
            foreach (DataColumn item in dt.Columns)
            {
                arrColWidth[item.Ordinal] = Encoding.GetEncoding(936).GetBytes(item.ColumnName.ToString()).Length;
            }
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    int intTemp = Encoding.GetEncoding(936).GetBytes(dt.Rows[i][j].ToString()).Length;
                    if (intTemp > arrColWidth[j])
                    {
                        arrColWidth[j] = intTemp;
                    }
                }
            }
            int rowIndex = 0;
            foreach (DataRow row in dt.Rows)
            {
                #region 表头 列头
                if (rowIndex == 65535 || rowIndex == 0)
                {
                    if (rowIndex != 0)
                    {
                        sheet = workbook.CreateSheet();
                    }

                    #region 表头及样式
                    {
                        var headerRow = sheet.CreateRow(0);
                        headerRow.HeightInPoints = 25;
                        headerRow.CreateCell(0).SetCellValue(columnHeader);
                        //CellStyle
                        ICellStyle headStyle = workbook.CreateCellStyle();
                        headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;// 左右居中    
                        headStyle.VerticalAlignment = VerticalAlignment.Center;// 上下居中 
                        // 设置单元格的背景颜色（单元格的样式会覆盖列或行的样式）    
                        headStyle.FillForegroundColor = (short)11;
                        //定义font
                        IFont font = workbook.CreateFont();
                        font.FontHeightInPoints = 20;
                        font.Boldweight = 700;
                        headStyle.SetFont(font);
                        headerRow.GetCell(0).CellStyle = headStyle;
                        sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, dt.Columns.Count - 1));
                    }
                    #endregion


                    #region 列头及样式
                    {
                        var headerRow = sheet.CreateRow(1);
                        //CellStyle
                        ICellStyle headStyle = workbook.CreateCellStyle();
                        headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;// 左右居中    
                        headStyle.VerticalAlignment = VerticalAlignment.Center;// 上下居中 
                        //定义font
                        IFont font = workbook.CreateFont();
                        font.FontHeightInPoints = 10;
                        font.Boldweight = 700;
                        headStyle.SetFont(font);

                        foreach (DataColumn column in dt.Columns)
                        {
                            headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                            headerRow.GetCell(column.Ordinal).CellStyle = headStyle;
                            sheet.SetColumnWidth(column.Ordinal, (arrColWidth[column.Ordinal] + 1) * 256);
                        }
                    }
                    #endregion
                    if (columnHeader == "")
                    {
                        //header row
                        IRow row0 = sheet.CreateRow(0);
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            ICell cell = row0.CreateCell(i, CellType.String);
                            cell.SetCellValue(dt.Columns[i].ColumnName);
                        }
                    }

                    rowIndex = 2;
                }
                #endregion


                #region 内容
                var dataRow = sheet.CreateRow(rowIndex);
                foreach (DataColumn column in dt.Columns)
                {
                    var newCell = dataRow.CreateCell(column.Ordinal);

                    string drValue = row[column].ToString();

                    switch (column.DataType.ToString())
                    {
                        case "System.String"://字符串类型
                            newCell.SetCellValue(drValue);
                            break;
                        case "System.DateTime"://日期类型
                            DateTime dateV;
                            DateTime.TryParse(drValue, out dateV);
                            newCell.SetCellValue(dateV);

                            newCell.CellStyle = dateStyle;//格式化显示
                            break;
                        case "System.Boolean"://布尔型
                            bool boolV = false;
                            bool.TryParse(drValue, out boolV);
                            newCell.SetCellValue(boolV);
                            break;
                        case "System.Int16"://整型
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            int intV = 0;
                            int.TryParse(drValue, out intV);
                            newCell.SetCellValue(intV);
                            break;
                        case "System.Decimal"://浮点型
                        case "System.Double":
                            double doubV = 0;
                            double.TryParse(drValue, out doubV);
                            newCell.SetCellValue(doubV);
                            break;
                        case "System.DBNull"://空值处理
                            newCell.SetCellValue("");
                            break;
                        default:
                            newCell.SetCellValue("");
                            break;
                    }

                }
                #endregion

                rowIndex++;
            }
            //自动列宽
            for (int i = 0; i <= dt.Columns.Count; i++)
                sheet.AutoSizeColumn(i, true);

            return workbook;
        }
        //导入数据
        public static void InputExcel(string fileAdd)
        {
            DataTable dt = new DataTable();
            using (var fs = File.OpenRead(@fileAdd))
            {
                //把xls文件中的数据写入workbook1中
                var workbook1 = new XSSFWorkbook(fs);
                for (var i = 0; i < workbook1.NumberOfSheets; i++)
                {
                    var sheet = workbook1.GetSheetAt(i);
                    Console.WriteLine("1:"+ sheet.LastRowNum);
                    for (var j = 0; j <= sheet.LastRowNum; j++)
                    {
                        //读取当前行数据
                        var row = sheet.GetRow(j);
                        if (row != null)
                        {
                            for (var k = 0; k <= row.LastCellNum; k++)
                            {   //当前表格
                                var cell = row.GetCell(k);
                                if (cell != null)
                                {
                                    Console.WriteLine(cell.ToString() + "  ");
                                    if (j == 1)
                                    {
                                        dt.Columns.Add(cell.ToString());
                                    }
                                    if(j >= 2)
                                    {
                                        DataRow dr = dt.NewRow();

                                        dr[dt.Columns[k].ToString()] = cell.ToString();

                                        dt.Rows.Add(dr);
                                    }
                                }
                            }
                        }                                        
                    }  
                }MessageBox.Show("输出成功");
                for (int l = 0; l < dt.Rows.Count; l++)
                {
                    for (int m = 0; m < dt.Columns.Count; m++)
                    {
                        Console.WriteLine("dt中每列的值："+dt.Rows[l][m].ToString());
                    }
                }
            }
        }

        #region 导入数据
        public static DataTable ImportExcelFile(string filePath)
        {
            #region//初始化信息
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    if (filePath.IndexOf(".xlsx") > 0) // 2007版本
                        hssfworkbook = new XSSFWorkbook(file);
                    else if (filePath.IndexOf(".xls") > 0) // 2003版本
                        hssfworkbook = new HSSFWorkbook(file);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            #endregion


            ISheet sheet = hssfworkbook.GetSheetAt(0);
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();
            DataTable dt = new DataTable();
            for (int j = 0; j < (sheet.GetRow(0).LastCellNum); j++)
            {
                dt.Columns.Add(Convert.ToChar(((int)'A') + j).ToString());
            }
            Console.WriteLine("有数据的行数："+ sheet.LastRowNum);
            while (rows.MoveNext())
            {
                XSSFRow row;
                HSSFRow row1;
                if (filePath.IndexOf(".xlsx") > 0)// Excel为2007版本
                { 
                    row = (XSSFRow)rows.Current;
                    DataRow dr = dt.NewRow();
                    if (row.GetCell(0) == null || row.GetCell(0).ToString() == "")
                    {
                        break;
                    }
                    //if (row <= sheet.LastRowNum)
                        for (int i = 0; i < row.LastCellNum; i++)
                    {
                        ICell cell = row.GetCell(i);         
                        if (cell == null)
                        {
                            dr[i] = null;
                            break;
                        }
                        else
                        {                        
                            if (cell.CellType == CellType.Formula)//如果单元格是公式
                            {
                                dr[i] = cell.CellFormula;
                            }//如果单元格是日期（Cell为非NUMERIC时，调用IsCellDateFormatted方法会报错，所以先要进行类型判断）
                            else if (cell.CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(cell))
                            {
                                dr[i] = cell.DateCellValue.ToString("yyyy/MM/dd");
                            }else if (cell.CellType == CellType.Numeric)//如果单元格是数字
                            {
                                dr[i] = cell.NumericCellValue;
                            }else if (cell.CellType == CellType.String)
                            {
                                dr[i] = cell.StringCellValue;
                            }else if (cell.CellType == CellType.Boolean)
                            {
                                dr[i] = cell.BooleanCellValue;
                            }
                            else if (cell.CellType == CellType.Blank)
                            {
                                break;
                            }
                            //else if (cell.CellType == CellType.Error)
                            //{
                            //    dr[i] = "";
                            //}
                            //else
                            //{
                            //    Console.WriteLine("该单元格数据类型未知！");
                            //}                              
                        }
                    }
                    dt.Rows.Add(dr);
                }
                else if (filePath.IndexOf(".xls") > 0)// Excel为2003版本   
                {                  
                    row1 = (HSSFRow)rows.Current;
                    DataRow dr1 = dt.NewRow();
                    for (int i = 0; i < row1.LastCellNum; i++)
                    {
                        ICell cell = row1.GetCell(i);
                        if (cell == null)
                        {
                            dr1[i] = null;
                        }
                        else
                        {
                            if (cell.CellType == CellType.Formula)//如果单元格是公式
                            {
                                dr1[i] = cell.CellFormula;
                            }//如果单元格是日期（Cell为非NUMERIC时，调用IsCellDateFormatted方法会报错，所以先要进行类型判断）
                            else if (cell.CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(cell))
                            {
                                dr1[i] = cell.DateCellValue.ToString("yyyy/MM/dd");
                            }
                            else if (cell.CellType == CellType.Numeric)//如果单元格是数字
                            {
                                dr1[i] = cell.NumericCellValue;
                            }
                            else if (cell.CellType == CellType.String)
                            {
                                dr1[i] = cell.StringCellValue;
                            }
                            else if (cell.CellType == CellType.Boolean)
                            {
                                dr1[i] = cell.BooleanCellValue;
                            }
                            else if (cell.CellType == CellType.Blank)
                            {                                
                                break;
                            }
                            //else if (cell.CellType == CellType.Error)
                            //{
                            //    dr1[i] = "";
                            //}
                            //else
                            //{
                            //    Console.WriteLine("该单元格数据类型未知！");
                            //}
                        }
                    }
                    dt.Rows.Add(dr1);
                }
            }
            Console.WriteLine("dt中的rows:"+rows.ToString());
            //遍历输出datatable
            for (int l = 1; l < dt.Rows.Count; l++)
            {
                for (int m = 0; m < dt.Columns.Count; m++)
                {
                    Console.WriteLine("dt中每列的值：" + dt.Rows[l][m].ToString());
                }
            }
            return dt;

        }
        //多个表格导入
       /* public static DataSet ImportExcelFiles(string filePath)
        {
            #region//初始化信息
            try
            {
                using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    if (filePath.IndexOf(".xlsx") > 0) // 2007版本
                        hssfworkbook = new XSSFWorkbook(file);
                    else if (filePath.IndexOf(".xls") > 0) // 2003版本
                        hssfworkbook = new HSSFWorkbook(file);


                }
            }
            catch (Exception e)
            {
                throw e;
            }
            #endregion
            DataSet ds = new DataSet();
            int numberOfSheets = hssfworkbook.NumberOfSheets;//sheets数量
            for (int n = 0; n < numberOfSheets; n++)
            {
                ISheet sheet = hssfworkbook.GetSheetAt(n);
                System.Collections.IEnumerator rows = sheet.GetRowEnumerator();
                DataTable dt = new DataTable();
                for (int j = 0; j < (sheet.GetRow(0).LastCellNum); j++)
                {
                    dt.Columns.Add(Convert.ToChar(((int)'A') + j).ToString());
                }
                while (rows.MoveNext())
                {
                    XSSFRow row;
                    HSSFRow row1;
                    if (filePath.IndexOf(".xlsx") > 0)
                    { // 2007版本
                        row = (XSSFRow)rows.Current;
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < row.LastCellNum; i++)
                        {
                            ICell cell = row.GetCell(i);
                            if (cell == null)
                            {
                                dr[i] = null;
                            }
                            else
                            {
                                if (cell.CellType == CellType.Formula)//如果单元格是公式
                                {
                                    dr[i] = cell.NumericCellValue.ToString();
                                }//Cell为非NUMERIC时，调用IsCellDateFormatted方法会报错，所以先要进行类型判断
                                else if (cell.CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(cell))
                                {
                                    dr[i] = cell.DateCellValue.ToString("yyyy/MM/dd");
                                }
                                else
                                {
                                    dr[i] = cell.ToString();
                                }
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                    else if (filePath.IndexOf(".xls") > 0)
                    { // 2003版本                    
                        row1 = (HSSFRow)rows.Current;
                        DataRow dr1 = dt.NewRow();
                        for (int i = 0; i < row1.LastCellNum; i++)
                        {
                            ICell cell = row1.GetCell(i);
                            if (cell == null)
                            {
                                dr1[i] = null;
                            }
                            else
                            {
                                if (cell.CellType == CellType.Formula)//如果单元格是公式
                                {
                                    dr1[i] = cell.NumericCellValue.ToString();
                                }//Cell为非NUMERIC时，调用IsCellDateFormatted方法会报错，所以先要进行类型判断
                                else if (cell.CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(cell))
                                {
                                    dr1[i] = cell.DateCellValue.ToString("yyyy/MM/dd");
                                }
                                else
                                {
                                    dr1[i] = cell.ToString();
                                }
                            }
                        }
                        dt.Rows.Add(dr1);
                    }
                }
                ds.Tables.Add(dt);
            }
            return ds;
        }*/
        #endregion
    }
}
