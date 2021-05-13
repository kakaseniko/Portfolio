using System;
using System.Collections.Generic;
using Classes;
using Interfaces;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class WksTests
    {
        IPersonLogic personlogic = new PersonLogic();
        [TestMethod]
        [ExpectedException (typeof(Exception))]
        public void TitleEmptyTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TopicEmptyTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
        }
        [TestMethod]
        public void AddParticipantToWksTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            owks.AddParticipant(stu);
            List<Person> expected = new List<Person>() { stu };
            CollectionAssert.AreEqual(expected, owks.GetParticipants());
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FullWorkshopTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 1, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            Student stu2 = new Student("John", "Dylan", "128456");
            personlogic.AddPerson(stu2);
            owks.AddParticipant(stu);
            owks.AddParticipant(stu2);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void EnrollAParticipantTwiceTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 3, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            owks.AddParticipant(stu);
            owks.AddParticipant(stu);
        }
        [TestMethod]
        public void RemoveAParticipantTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 3, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            Student stu2 = new Student("John", "Dylan", "128456");
            personlogic.AddPerson(stu2);
            owks.AddParticipant(stu);
            owks.AddParticipant(stu2);
            owks.RemoveParticipant(stu2);
            List<Person> expected = new List<Person>() { stu };
            CollectionAssert.AreEqual(expected, owks.GetParticipants());
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveANonExistentParticipantTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 3, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            Student stu2 = new Student("John", "Dylan", "128456");
            personlogic.AddPerson(stu2);
            owks.AddParticipant(stu);
            owks.RemoveParticipant(stu2);
        }
        [TestMethod]
        public void GetParticipantsTest()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An online workshop", "How to give online workshops", DateTime.Now, 3, (Teacher)personlogic.GetPerson("159357"), "somelink");
            Student stu = new Student("John", "Smith", "123456");
            personlogic.AddPerson(stu);
            Student stu2 = new Student("John", "Dylan", "128456");
            personlogic.AddPerson(stu2);
            owks.AddParticipant(stu);
            owks.AddParticipant(stu2);
            List<Person> expected = new List<Person>() { stu, stu2 };
            CollectionAssert.AreEqual(expected, owks.GetParticipants());
        }
    }
}
