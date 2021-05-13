using System;
using System.Collections.Generic;
using Classes;
using Interfaces;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class WksLogicTests
    {
        IWorkshopLogic wkslogic = new WorkshopLogic();
        IPersonLogic personlogic = new PersonLogic();
        [TestMethod]
        public void AddAParticipantToAWks()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            wkslogic.AddParticipantToWks(owks, stu);
            List<Person> expected = new List<Person>() { stu };
            CollectionAssert.AreEqual(expected, owks.GetParticipants());
        }
        [TestMethod]
        public void RemoveAParticipantFromAWks()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            Student stu2 = new Student("John", "Dylan", "128456");
            personlogic.AddPerson(stu2);
            wkslogic.AddParticipantToWks(owks, stu);
            wkslogic.AddParticipantToWks(owks, stu2);
            wkslogic.RemoveParticipantFromWks(owks, stu2);
            List<Person> expected = new List<Person>() { stu };
            CollectionAssert.AreEqual(expected, owks.GetParticipants());
        }
        [TestMethod]
        public void GenerateALoginCode()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            wkslogic.AddParticipantToWks(owks, stu);
            wkslogic.GenerateLoginCode(owks, stu);
            string expected = "WKS0P123456C1";
            Assert.AreEqual(expected, stu.GetAttendances()[0].LoginCode);
        }
        [TestMethod]
        public void GenerateASeatNumber()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            InBuildingWks offwks = new InBuildingWks("An offline workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "address", 5);
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            wkslogic.AddParticipantToWks(offwks, stu);
            wkslogic.GenerateSeatNumber(offwks);
            int expected = 1;
            Assert.AreEqual(expected, stu.GetAttendances()[0].SeatNumber);
        }
        [TestMethod]
        public void StartAWks()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            InBuildingWks offwks = new InBuildingWks("An offline workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "address", 5);
            wkslogic.StartWks(offwks);
            Assert.AreEqual(true, offwks.IsStarted);
        }
       
    }
}
