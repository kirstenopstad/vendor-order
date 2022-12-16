using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void CreateInstance_CreateInstanceOfVendor_Vendor()
    {
      string name="Suzie's Cafe";
      string description="Coffee shop";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_GetVendorInstanceName_String()
    {
      // Arrange
      string name="Suzie's Cafe";
      string description="Coffee shop";
      Vendor newVendor = new Vendor(name, description);
      //Act
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_GetVendorInstanceDescription_String()
    {
      // Arrange
      string name="Suzie's Cafe";
      string description="Coffee shop";
      Vendor newVendor = new Vendor(name, description);
      //Act
      string result = newVendor.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAllEmpty_GetEmptyListOfVendorOrders_List()
    {
      // Arrange
      List<Vendor> newList = new List<Vendor> { };
      // Act
      List<Vendor> result = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_GetAllInstancesOfVendor_List()
    {
      // Arrange
      string name="Suzie's Cafe";
      string description="Coffee shop";
      Vendor newVendor1 = new Vendor(name, description);
      string name2="Happy Returns";
      string description2="Retirement home";
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      // Act
      List<Vendor> result = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearAllInstancesOfVendor_List()
    {
      // Arrange
      string name="Suzie's Cafe";
      string description="Coffee shop";
      Vendor newVendor1 = new Vendor(name, description);
      string name2="Happy Returns";
      string description2="Retirement home";
      Vendor newVendor2 = new Vendor(name, description);
      List<Vendor> newList = new List<Vendor> {};
      // Act
      Vendor.ClearAll();
      List<Vendor> result = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result); 
    }
  }
}