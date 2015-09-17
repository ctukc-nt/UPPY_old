using System.Collections.Generic;
using System.IO;
using Core.DomainModel;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace UPPY.DIE.Export
{
    public class ExportExcelFile
    {
        public void CreatePassportProjectToFile(HierarchyNumberDrawing masterDrawing, List<HierarchyNumberDrawing> list, string fileName)
        {
            ExcelPackage pck = new ExcelPackage();
            var ws = pck.Workbook.Worksheets.Add("Паспорт");
            CreateHeaderPassport(ws);
            for (int i = 0; i < list.Count; i++)
            {
                AppendProjectToSheetWithoutTechOper(list[i], ws, i + 4);
            }
            pck.SaveAs(new FileInfo(fileName));
        }

        public void CreatePassportProjectToFile(HierarchyNumberDrawing masterDrawing, List<HierarchyNumberDrawing> list, List<TechOperation> techOperations, string fileName)
        {
            
        }


        private void CreateHeaderPassport(ExcelWorksheet ws)
        {
            ws.Cells["A2:Q2"].Merge = true;
            ws.Cells["A2:Q2"].Value = "Заголовок";
            ws.Cells["A2:Q2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            SetStyleToAllLinesSquare(ws.Cells["A2:Q2"], ExcelBorderStyle.Thick);

            FillHeaderSquare(ws.Cells["A3"], "№ п/п");
            ws.Column(1).Width = 11;

            FillHeaderSquare(ws.Cells["B3"], "№ поз. по спец-ии");
            ws.Column(2).Width = 11;

            FillHeaderSquare(ws.Cells["C3"], "Обозначение");
            ws.Column(3).Width = 27;

            FillHeaderSquare(ws.Cells["D3"], "Наименование");
            ws.Column(4).Width = 50;

            FillHeaderSquare(ws.Cells["E3"], "Профиль");
            ws.Column(5).Width = 12;

            FillHeaderSquare(ws.Cells["F3"], "Типоразмер");
            ws.Column(6).Width = 14;

            FillHeaderSquare(ws.Cells["G3"], "Мерность");
            ws.Column(7).Width = 12;

            FillHeaderSquare(ws.Cells["H3"], "ГОСТ на сортамент");
            ws.Column(8).Width = 16;

            FillHeaderSquare(ws.Cells["I3"], "Марка стали");
            ws.Column(9).Width = 15;

            FillHeaderSquare(ws.Cells["J3"], "ГОСТ на материал");
            ws.Column(10).Width = 11;

            FillHeaderSquare(ws.Cells["K3"], "Длина");
            ws.Column(11).Width = 12;

            FillHeaderSquare(ws.Cells["L3"], "Ширина");
            ws.Column(12).Width = 12;

            FillHeaderSquare(ws.Cells["M3"], "Кол-во на 1 сб. ед.");
            ws.Column(13).Width = 10;

            FillHeaderSquare(ws.Cells["N3"], "Кол-во всего");
            ws.Column(14).Width = 10;

            FillHeaderSquare(ws.Cells["O3"], "Масса на 1 ед., кг.");
            ws.Column(15).Width = 14;

            FillHeaderSquare(ws.Cells["P3"], "Масса всего, кг.");
            ws.Column(16).Width = 14;

            FillHeaderSquare(ws.Cells["Q3"], "ОТПРАВОЧНЫЕ ПОЗИЦИИ (ОП)");
            ws.Column(17).Width = 25;
        }

        private static void AppendProjectToSheetWithoutTechOper(HierarchyNumberDrawing drawing, ExcelWorksheet workSheet, int i)
        {
            workSheet.Cells["A" + i].Value = drawing.HierarchyNumber;
            SetStyleToAllLinesSquare(workSheet.Cells["A" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["B" + i].Value = drawing.NumberOnSpec;
            SetStyleToAllLinesSquare(workSheet.Cells["B" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["C" + i].Value = drawing.Designation;
            SetStyleToAllLinesSquare(workSheet.Cells["C" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["D" + i].Value = drawing.Name;
            SetStyleToAllLinesSquare(workSheet.Cells["D" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["E" + i].Value = drawing.Profile;
            SetStyleToAllLinesSquare(workSheet.Cells["E" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["F" + i].Value = drawing.StandartSize;
            SetStyleToAllLinesSquare(workSheet.Cells["F" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["G" + i].Value = string.Empty;
            SetStyleToAllLinesSquare(workSheet.Cells["G" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["H" + i].Value = drawing.GostOnSort;
            SetStyleToAllLinesSquare(workSheet.Cells["H" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["I" + i].Value = drawing.MarkSteal;
            SetStyleToAllLinesSquare(workSheet.Cells["I" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["J" + i].Value = drawing.GostOnMaterial;
            SetStyleToAllLinesSquare(workSheet.Cells["J" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["K" + i].Value = drawing.Length;
            SetStyleToAllLinesSquare(workSheet.Cells["K" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["L" + i].Value = drawing.Width;
            SetStyleToAllLinesSquare(workSheet.Cells["L" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["M" + i].Value = drawing.Count;
            SetStyleToAllLinesSquare(workSheet.Cells["M" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["N" + i].Value = drawing.CountAll;
            SetStyleToAllLinesSquare(workSheet.Cells["N" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["O" + i].Value = drawing.Weight;
            SetStyleToAllLinesSquare(workSheet.Cells["O" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["P" + i].Value = drawing.WeightAll;
            SetStyleToAllLinesSquare(workSheet.Cells["P" + i], ExcelBorderStyle.Thin);
            workSheet.Cells["Q" + i].Value = drawing.OP;
            SetStyleToAllLinesSquare(workSheet.Cells["Q" + i], ExcelBorderStyle.Thin);
        }

        private void FillHeaderSquare(ExcelRange range, string value)
        {
            range.Value = value;
            SetStyleToAllLinesSquare(range, ExcelBorderStyle.Thick);
            range.Style.WrapText = true;
            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            range.Style.Font.Bold = true;
        }

        private static void SetStyleToAllLinesSquare(ExcelRange range ,ExcelBorderStyle style)
        {
            range.Style.Border.Bottom.Style = style;
            range.Style.Border.Top.Style = style;
            range.Style.Border.Left.Style = style;
            range.Style.Border.Right.Style = style;
        }

    }
}