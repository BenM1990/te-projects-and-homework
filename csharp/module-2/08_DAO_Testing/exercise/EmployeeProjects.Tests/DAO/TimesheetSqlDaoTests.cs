using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EmployeeProjects.DAO;
using EmployeeProjects.Models;

namespace EmployeeProjects.Tests.DAO
{
    [TestClass]
    public class TimesheetSqlDaoTests : BaseDaoTests
    {
        private static readonly Timesheet TIMESHEET_1 = new Timesheet(1, 1, 1, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 1");
        private static readonly Timesheet TIMESHEET_2 = new Timesheet(2, 1, 1, DateTime.Parse("2021-01-02"), 1.5M, true, "Timesheet 2");
        private static readonly Timesheet TIMESHEET_3 = new Timesheet(3, 2, 1, DateTime.Parse("2021-01-01"), 0.25M, true, "Timesheet 3");
        private static readonly Timesheet TIMESHEET_4 = new Timesheet(4, 2, 2, DateTime.Parse("2021-02-01"), 2.0M, false, "Timesheet 4");

        private TimesheetSqlDao dao;


        [TestInitialize]
        public override void Setup()
        {
            dao = new TimesheetSqlDao(ConnectionString);
            base.Setup();
        }

        [TestMethod]
        public void GetTimesheet_ReturnsCorrectTimesheetForId()
        {
            Timesheet timesheet = dao.GetTimesheet(1);
            AssertTimesheetsMatch(TIMESHEET_1, timesheet);
        }

    
        [TestMethod]
        public void GetTimesheet_ReturnsNullWhenIdNotFound()
        {
            Timesheet timesheet = dao.GetTimesheet(99);
            Assert.IsNull(timesheet);

        }

        [TestMethod] //bug
        public void GetTimesheetsByEmployeeId_ReturnsListOfAllTimesheetsForEmployee()
        {
            IList<Timesheet> timesheets = dao.GetTimesheetsByEmployeeId(1);
            IList<Timesheet> expectedTimesheets = new List<Timesheet>();
            expectedTimesheets.Add(TIMESHEET_1);


            
            Assert.AreEqual(expectedTimesheets.Count, timesheets.Count);



        }

        [TestMethod] //bug
        public void GetTimesheetsByProjectId_ReturnsListOfAllTimesheetsForProject()
        {
            IList<Timesheet> timesheets = dao.GetTimesheetsByProjectId(1);
            Assert.AreEqual(3, timesheets.Count);
            AssertTimesheetsMatch(TIMESHEET_1, timesheets[0]);
            AssertTimesheetsMatch(TIMESHEET_2, timesheets[1]);
            AssertTimesheetsMatch(TIMESHEET_3, timesheets[2]);

            timesheets = dao.GetTimesheetsByProjectId(1);
            Assert.AreEqual(3, timesheets.Count);

        }

        [TestMethod] // bug
        public void CreateTimesheet_ReturnsTimesheetWithIdAndExpectedValues()
        {
            Timesheet timesheet = new Timesheet(5, 3, 2, DateTime.Now, 1.0M, true, "TIMESHEET_5");

            int newTimesheet = timesheet.TimesheetId;
            Assert.IsTrue(newTimesheet > 0);

            
        }

        [TestMethod]
        public void CreatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet createdTimesheet = dao.CreateTimesheet(TIMESHEET_1);

            int newId = createdTimesheet.TimesheetId;
            Timesheet retrievedTimesheet = dao.GetTimesheet(newId);

            AssertTimesheetsMatch(createdTimesheet, retrievedTimesheet);
        }

        [TestMethod] // bug
        public void UpdatedTimesheetHasExpectedValuesWhenRetrieved()
        {

            Timesheet timesheetToUpdate = dao.GetTimesheet(2); 

            timesheetToUpdate.IsBillable = false;

            dao.UpdateTimesheet(timesheetToUpdate); 

            Timesheet retrievedTimesheet = dao.GetTimesheet(2);

            AssertTimesheetsMatch(timesheetToUpdate, retrievedTimesheet);
        }

        [TestMethod]
        public void DeletedTimesheetCantBeRetrieved()
        {
            dao.DeleteTimesheet(3);

            Timesheet retrievedTimesheet = dao.GetTimesheet(3);
            Assert.IsNull(retrievedTimesheet);
        }

        [TestMethod] // bug
        public void GetBillableHours_ReturnsCorrectTotal()
        {
            decimal billableHours = dao.GetBillableHours(2, 2);

            Assert.AreEqual(2, billableHours);

        }

        private void AssertTimesheetsMatch(Timesheet expected, Timesheet actual)
        {
            Assert.AreEqual(expected.TimesheetId, actual.TimesheetId);
            Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
            Assert.AreEqual(expected.ProjectId, actual.ProjectId);
            Assert.AreEqual(expected.DateWorked, actual.DateWorked);
            Assert.AreEqual(expected.HoursWorked, actual.HoursWorked);
            Assert.AreEqual(expected.IsBillable, actual.IsBillable);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}
