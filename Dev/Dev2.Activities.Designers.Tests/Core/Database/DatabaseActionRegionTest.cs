﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Dev2.Activities.Designers2.Core.ActionRegion;
using Dev2.Activities.Designers2.Core.Source;
using Dev2.Common.Interfaces.Core;
using Dev2.Common.Interfaces.Core.DynamicServices;
using Dev2.Common.Interfaces.DB;
using Dev2.Common.Interfaces.ServerProxyLayer;
using Dev2.Common.Interfaces.ToolBase;
using Dev2.Studio.Core.Activities.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Warewolf.Core;

// ReSharper disable InconsistentNaming

namespace Dev2.Activities.Designers.Tests.Core.Database
{
    [TestClass]
    public class DatabaseActionRegionTest
    {
        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory("DatabaseActionRegion_Constructor")]
        public void DatabaseActionRegion_Constructor_Scenerio_Result()
        {
            //------------Setup for test--------------------------
            var src = new Mock<IDbServiceModel>();
            src.Setup(a => a.RetrieveSources()).Returns(new ObservableCollection<IDbSource>());
            DatabaseSourceRegion sourceRegion = new DatabaseSourceRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()),enSourceType.SqlDatabase);

            //------------Execute Test---------------------------
            DbActionRegion dbActionRegion = new DbActionRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()), sourceRegion);

            //------------Assert Results-------------------------
            Assert.AreEqual(25, dbActionRegion.CurrentHeight);
            Assert.AreEqual(25, dbActionRegion.MaxHeight);
            Assert.AreEqual(25, dbActionRegion.MinHeight);
            Assert.AreEqual(1, dbActionRegion.Errors.Count);
            Assert.IsTrue(dbActionRegion.IsVisible);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory("DatabaseActionRegion_ConstructorWithSelectedAction")]
        public void DatabaseActionRegion_ConstructorWithSelectedAction_Scenerio_Result()
        {
            //------------Setup for test--------------------------
            var id = Guid.NewGuid();
            var act = new DsfSqlServerDatabaseActivity() { SourceId = id };
            var src = new Mock<IDbServiceModel>();
            var dbsrc = new DbSourceDefinition() { Id = id };
            var action = new DbAction() { Name = "bravo" };
            src.Setup(a => a.RetrieveSources()).Returns(new ObservableCollection<IDbSource>() { dbsrc });

            DatabaseSourceRegion sourceRegion = new DatabaseSourceRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()),enSourceType.SqlDatabase);

            //------------Execute Test---------------------------
            DbActionRegion dbActionRegion = new DbActionRegion(src.Object, ModelItemUtils.CreateModelItem(act), sourceRegion);
            dbActionRegion.SelectedAction = action;

            //------------Assert Results-------------------------
            Assert.AreEqual(action, dbActionRegion.SelectedAction);
            Assert.IsTrue(dbActionRegion.CanRefresh());
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory("DatabaseActionRegion_ChangeActionSomethingChanged")]
        public void DatabaseActionRegion_ChangeActionSomethingChanged_ExpectedChange_Result()
        {
            //------------Setup for test--------------------------
            var id = Guid.NewGuid();
            var act = new DsfSqlServerDatabaseActivity() { SourceId = id };
            var src = new Mock<IDbServiceModel>();
            var dbsrc = new DbSourceDefinition() { Id = id };
            var evt = false;
            var s2 = new DbSourceDefinition() { Id = Guid.NewGuid() };
            var action = new DbAction() { Name = "bravo" };
            src.Setup(a => a.RetrieveSources()).Returns(new ObservableCollection<IDbSource>() { dbsrc, s2 });

            DatabaseSourceRegion sourceRegion = new DatabaseSourceRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()), enSourceType.SqlDatabase);

            //------------Execute Test---------------------------
            DbActionRegion dbActionRegion = new DbActionRegion(src.Object, ModelItemUtils.CreateModelItem(act), sourceRegion);
            dbActionRegion.SomethingChanged += (a, b) => { evt = true; };
            dbActionRegion.SelectedAction = action;

            //------------Assert Results-------------------------
            Assert.IsTrue(evt);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory("DatabaseActionRegion_ChangeActionSomethingChanged")]
        public void DatabaseActionRegion_ChangeActionSomethingChanged_RestoreRegion_Result()
        {
            //------------Setup for test--------------------------
            var id = Guid.NewGuid();
            var act = new DsfSqlServerDatabaseActivity() { SourceId = id };
            var src = new Mock<IDbServiceModel>();
            var dbsrc = new DbSourceDefinition() { Id = id, Name = "bob" };
            var action = new DbAction() { Name = "bravo" ,SourceId = id};

            var s2 = new DbSourceDefinition() { Id = Guid.NewGuid(), Name = "bob" };
            var action1 = new DbAction() { Name = "bravo" ,SourceId = Guid.NewGuid()};
            src.Setup(a => a.RetrieveSources()).Returns(new ObservableCollection<IDbSource>() { dbsrc, s2 });

            DatabaseSourceRegion sourceRegion = new DatabaseSourceRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()), enSourceType.SqlDatabase);

            //------------Execute Test---------------------------
            DbActionRegion dbActionRegion = new DbActionRegion(src.Object, ModelItemUtils.CreateModelItem(act), sourceRegion);

            var clone1 = new Mock<IToolRegion>();
            var clone2 = new Mock<IToolRegion>();
            var dep1 = new Mock<IToolRegion>();
            dep1.Setup(a => a.CloneRegion()).Returns(clone1.Object);

            var dep2 = new Mock<IToolRegion>();
            dep2.Setup(a => a.CloneRegion()).Returns(clone2.Object);
            dbActionRegion.Dependants = new List<IToolRegion> { dep1.Object, dep2.Object };
            dbActionRegion.SelectedAction = action;
            dbActionRegion.SelectedAction = action1;

            //------------Assert Results-------------------------
            dep1.Verify(a => a.RestoreRegion(clone1.Object),Times.Never);
            dep2.Verify(a => a.RestoreRegion(clone2.Object),Times.Never);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory("DatabaseActionRegion_ChangeActionSomethingChanged")]
        public void DatabaseActionRegion_ChangeActionSomethingChanged_RegionsNotRestored_Invalid()
        {
            //------------Setup for test--------------------------
            var id = Guid.NewGuid();
            var act = new DsfSqlServerDatabaseActivity() { SourceId = id };
            var src = new Mock<IDbServiceModel>();
            var dbsrc = new DbSourceDefinition() { Id = id };
            var action = new DbAction() { Name = "bravo" };

            var s2 = new DbSourceDefinition() { Id = Guid.NewGuid() };
            var action1 = new DbAction() { Name = "bravo" };
            src.Setup(a => a.RetrieveSources()).Returns(new ObservableCollection<IDbSource>() { dbsrc, s2 });

            DatabaseSourceRegion sourceRegion = new DatabaseSourceRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()), enSourceType.SqlDatabase);

            //------------Execute Test---------------------------
            DbActionRegion dbActionRegion = new DbActionRegion(src.Object, ModelItemUtils.CreateModelItem(act), sourceRegion);

            var clone1 = new Mock<IToolRegion>();
            var clone2 = new Mock<IToolRegion>();
            var dep1 = new Mock<IToolRegion>();
            dep1.Setup(a => a.CloneRegion()).Returns(clone1.Object);

            var dep2 = new Mock<IToolRegion>();
            dep2.Setup(a => a.CloneRegion()).Returns(clone2.Object);
            dbActionRegion.Dependants = new List<IToolRegion> { dep1.Object, dep2.Object };
            dbActionRegion.SelectedAction = action;
            dbActionRegion.SelectedAction = action1;

            //------------Assert Results-------------------------
            dep1.Verify(a => a.RestoreRegion(clone1.Object), Times.Never);
            dep2.Verify(a => a.RestoreRegion(clone2.Object), Times.Never);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory("DatabaseActionRegion_ChangeActionSomethingChanged")]
        public void DatabaseActionRegion_ChangeActionSomethingChanged_CloneRegion_ExpectedClone()
        {
            //------------Setup for test--------------------------
            var id = Guid.NewGuid();
            var act = new DsfSqlServerDatabaseActivity() { SourceId = id };
            var src = new Mock<IDbServiceModel>();
            var dbsrc = new DbSourceDefinition() { Id = id };
            var s2 = new DbSourceDefinition() { Id = Guid.NewGuid() };
            src.Setup(a => a.RetrieveSources()).Returns(new ObservableCollection<IDbSource>() { dbsrc, s2 });

            DatabaseSourceRegion sourceRegion = new DatabaseSourceRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()), enSourceType.SqlDatabase);

            //------------Execute Test---------------------------
            DbActionRegion dbActionRegion = new DbActionRegion(src.Object, ModelItemUtils.CreateModelItem(act), sourceRegion);
            var cloned = dbActionRegion.CloneRegion();

            //------------Assert Results-------------------------
            Assert.AreEqual(cloned.CurrentHeight, dbActionRegion.CurrentHeight);
            Assert.AreEqual(cloned.MaxHeight, dbActionRegion.MaxHeight);
            Assert.AreEqual(cloned.IsVisible, dbActionRegion.IsVisible);
            Assert.AreEqual(cloned.MinHeight, dbActionRegion.MinHeight);
            Assert.AreEqual(((DbActionMemento)cloned).SelectedAction, dbActionRegion.SelectedAction);
        }

        [TestMethod]
        [Owner("Pieter Terblanche")]
        [TestCategory("DatabaseActionRegion_ChangeActionSomethingChanged")]
        public void DatabaseActionRegion_ChangeActionSomethingChanged_RestoreRegion_ExpectedRestore()
        {
            //------------Setup for test--------------------------
            var id = Guid.NewGuid();
            var act = new DsfSqlServerDatabaseActivity() { SourceId = id };
            var src = new Mock<IDbServiceModel>();
            var dbsrc = new DbSourceDefinition() { Id = id };
            var s2 = new DbSourceDefinition() { Id = Guid.NewGuid() };
            var action = new DbAction() { Name = "bravo" };
            src.Setup(a => a.RetrieveSources()).Returns(new ObservableCollection<IDbSource>() { dbsrc, s2 });

            DatabaseSourceRegion sourceRegion = new DatabaseSourceRegion(src.Object, ModelItemUtils.CreateModelItem(new DsfSqlServerDatabaseActivity()), enSourceType.SqlDatabase);

            //------------Execute Test---------------------------
            DbActionRegion dbActionRegion = new DbActionRegion(src.Object, ModelItemUtils.CreateModelItem(act), sourceRegion);
            // ReSharper disable once UseObjectOrCollectionInitializer
            DbActionMemento dbActionRegionToRestore = new DbActionMemento();
            dbActionRegionToRestore.MaxHeight = 144;
            dbActionRegionToRestore.MinHeight = 133;
            dbActionRegionToRestore.CurrentHeight = 111;
            dbActionRegionToRestore.IsVisible = false;
            dbActionRegionToRestore.SelectedAction = action;

            dbActionRegion.RestoreRegion(dbActionRegionToRestore);

            //------------Assert Results-------------------------
            Assert.AreEqual(dbActionRegion.MaxHeight, 144);
            Assert.AreEqual(dbActionRegion.MinHeight, 133);
            Assert.AreEqual(dbActionRegion.CurrentHeight, 111);
            Assert.AreEqual(dbActionRegion.SelectedAction, action);
            Assert.IsFalse(dbActionRegion.IsVisible);
        }
    }
}
