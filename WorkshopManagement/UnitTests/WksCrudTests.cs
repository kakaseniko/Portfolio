using System;
using System.Collections.Generic;
using Classes;
using Interfaces;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class WksCrudTests
    {
        IWorkshopCRUDLogic wkscrud = new WorkshopCRUDLogic();
        IPersonLogic personlogic = new PersonLogic();
        [TestMethod]
        public void AddWorkshop()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An Online Workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            wkscrud.AddWorkshop(owks);
            Assert.AreEqual(owks, wkscrud.GetWorkshop(1));

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddWorkshopWithSameTitle()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An Online Workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            OnlineWks owks2 = new OnlineWks("An Online Workshop", "test", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "test");
            wkscrud.AddWorkshop(owks);
            wkscrud.AddWorkshop(owks2);
        }

        [TestMethod]
        public void EditAWorkshop()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An Online Workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            OnlineWks owks2 = new OnlineWks("An Online Workshop", "test", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "test");
            wkscrud.AddWorkshop(owks);
            wkscrud.EditWorkshop(owks, owks2);
            Assert.AreEqual("test", wkscrud.GetWorkshop(1).Topic);
        }
        [TestMethod]
        public void GetWorkshop()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An Online Workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            OnlineWks owks2 = new OnlineWks("test", "test", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "test");
            wkscrud.AddWorkshop(owks);
            wkscrud.AddWorkshop(owks2);
            Assert.AreEqual(owks2, wkscrud.GetWorkshop(2));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NoWorkshopWithEnteredID()
        {
            wkscrud.GetWorkshop(1);
        }
        [TestMethod]
        public void RemoveAWorkshop()
        {
            personlogic.AddPerson(new Teacher("John", "Teacher", "159357"));
            OnlineWks owks = new OnlineWks("An Online Workshop", "How to give online workshops", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "somelink");
            OnlineWks owks2 = new OnlineWks("test", "test", DateTime.Now, 5, (Teacher)personlogic.GetPerson("159357"), "test");
            wkscrud.AddWorkshop(owks);
            wkscrud.AddWorkshop(owks2);
            wkscrud.RemoveWorkshop(owks2);
            List<Workshop> expected = new List<Workshop>() { owks };
            CollectionAssert.AreEqual(expected, wkscrud.GetAllWorkshops());
        }

    }
}
