using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Collections;
using WindowsFormsApplication1.Resources;

namespace WindowsFormsApplication1
{
    static class Employee
    {
        private static string EmployeeNo = "";
        private static string CardNo = "";
        private static string EmpLanguageCode = "";
        private static string DefaultWorkCenter = "";
        private static string WorkingWorkCenter = "";
        private static string TimeGroupCode = "";
        private static string AbsenceCode = "";
        private static string FirstName = "";
        private static string LastName = "";

        public static string TheEmployeeNo
        {
            get { return EmployeeNo; }
            set { EmployeeNo = value; }
        }
        public static string TheCardNo
        {
            get { return CardNo; }
            set { CardNo = value; }
        }
        public static string TheLanguageCode
        {
            get { return EmpLanguageCode; }
            set { EmpLanguageCode = value; }
        }
        public static string TheDefaultWorkCenter
        {
            get { return DefaultWorkCenter; }
            set { DefaultWorkCenter = value; }
        }
        public static string TheWorkingWorkCenter
        {
            get { return WorkingWorkCenter; }
            set { WorkingWorkCenter = value; }
        }
        public static string TheTimeGroupCode
        {
            get { return TimeGroupCode; }
            set { TimeGroupCode = value; }
        }
        public static string TheAbsenceCode
        {
            get { return AbsenceCode; }
            set { AbsenceCode = value; }
        }
        public static string TheFirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public static string TheLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
    }
    static class Globals
    {
        private static string LocationCode = "";
        private static string UserID = "";
        private static string Name = "";
        private static string WinLogon = "";
        private static bool come = false;
        private static bool production = false;
        private static int step = 0;

        public static string TheGlobalLocation
        {
            get { return LocationCode; }
            set { LocationCode = value; }
        }
        public static string TheGlobalUserVar
        {
            get { return UserID; }
            set { UserID = value; }
        }
        public static string GlobalNameVar
        {
            get { return Name; }
            set { Name = value; }
        }
        public static int TheGlobalStep
        {
            get { return step; }
            set { step = value; }
        }
        public static string WINLOGON
        {
            get { return WinLogon; }
            set { WinLogon = value; }
        }
        public static bool TheGlobalCome
        {
            get { return come; }
            set { come = value; }
        }
        public static bool TheGlobalProduction
        {
            get { return production; }
            set { production = value; }
        }
        public static string theGlobalUserId
        {
            get { return UserID; }
            set { UserID = value; }
        }
    }
    static class classProductionOrder
    {
        private static string WorkCenter = "";
        private static string ProductionOrder = "";
        private static string Operation = "";
        private static int Direction = 2;
        private static double FinishedQuantity = 0;
        private static double ScrapQuantity = 0;
        private static string StopCode = "";
        private static string BinCode = "";
        private static string LotNr = "";
        private static string ProdLineNr = "";

        public static string TheWorkCenter
        {
            get { return WorkCenter; }
            set { WorkCenter = value; }
        }

        public static string TheProductionOrder
        {
            get { return ProductionOrder; }
            set { ProductionOrder = value; }
        }
        public static string TheOperation
        {
            get { return Operation; }
            set { Operation = value; }
        }
        public static int TheDirection
        {
            get { return Direction; }
            set { Direction = value; }
        }
        public static double TheFinishedQuantity
        {
            get { return FinishedQuantity; }
            set { FinishedQuantity = value; }
        }
        public static double TheScrapQuantity
        {
            get { return ScrapQuantity; }
            set { ScrapQuantity = value; }
        }
        public static string TheStopCode
        {
            get { return StopCode; }
            set { StopCode = value; }
        }
        public static string TheBinCode
        {
            get { return BinCode; }
            set { BinCode = value; }
        }
        public static string TheLotNo
        {
            get { return LotNr; }
            set { LotNr = value; }
        }
        public static string TheProLineNr
        {
            get { return ProdLineNr; }
            set { ProdLineNr = value; }
        }
    }
    static class classWorkcenter
    {
        private static string No = "0";
        private static string Name = "";
        private static string Workcenter = "";

        public static string TheNo
        {
            get { return No; }
            set { No = value; }
        }
        public static string TheName
        {
            get { return Name; }
            set { Name = value; }
        }
        public static string TheWorkCenter
        {
            get { return Workcenter; }
            set { Workcenter = value; }
        }
    }
    public class MyToolbox
    {
        public string ReadResFile(string key)
        {
            string resourceValue = string.Empty;
            string file = "";
            switch (Employee.TheLanguageCode)
            {
                case "da-DK": file = "Message.da-DK.resx";
                    break;
                case "de-DE": file = "Message.de-DE.resx";
                    break;
                case "en-US": file = "Message.en-US.resx";
                    break;
            }
            ResXResourceReader r = new ResXResourceReader(file);
            IDictionaryEnumerator en = r.GetEnumerator();

            while (en.MoveNext())
            {
                if (en.Key.Equals(key))
                {
                    return resourceValue = en.Value.ToString();
                }
            }
            r.Close();
            return "";
        }

        public string ReturnWorkCenterName(string WorkCenterCode)
        {
            var dbWorkCenter = new WorkCenterConnDataContext();
            var WorkCenters =
                from WorkCenter in dbWorkCenter.Credin_Work_Centers
                where WorkCenter.No_.Equals(WorkCenterCode)
                select new { WorkCenter.Name };
            if (WorkCenters.Count() > 0)
            {
                foreach (var item in WorkCenters)
                {
                    return item.Name;
                }
            }
            return "";
        }

        public string ReturAbsenceName(string AbsenceCode)
        {
            var dbAbsence = new AbsenceConnDataContext();
            var Absences =
                from Absence in dbAbsence.Credin_Cause_of_Absences
                where Absence.Code.Equals(AbsenceCode)
                select new { Absence.Description };
            if (Absences.Count() > 0)
            {
                foreach (var item in Absences)
                {
                    return item.Description;
                }
            }
            return "";
        }
    }
}
