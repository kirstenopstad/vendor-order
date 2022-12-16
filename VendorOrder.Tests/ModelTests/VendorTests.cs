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
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> {};
      // Act
      Vendor.ClearAll();
      List<Vendor> result = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result); 
    }

    [TestMethod]
    public void GetId_GetInstanceId_int()
    {
      // Arrange
      string name="Suzie's Cafe";
      string description="Coffee shop";
      Vendor newVendor = new Vendor(name, description);
      // Act
      int result = newVendor.Id;
      // Assert 
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_FindInstanceById_Vendor()
    {
      // Arrange
      string name="Suzie's Cafe";
      string description="Coffee shop";
      Vendor newVendor1 = new Vendor(name, description);
      string name2="Happy Returns";
      string description2="Retirement home";
      Vendor newVendor2 = new Vendor(name2, description2);
      // Act
      Vendor result = Vendor.Find(2);
      // Assert
      Assert.AreEqual(newVendor2, result);
    }
    
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      // Arrange
      // Create Order
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      // Create Vendor
      string vendorName="Suzie's Cafe";
      string vendorDescription="Coffee shop";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      // Add order to vendor
      newVendor.AddOrder(newOrder);

      // Act
      List<Order> result = newVendor.Orders;

      // Assert 
      CollectionAssert.AreEqual(newList, result);
    }
  }
}