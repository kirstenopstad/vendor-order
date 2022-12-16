using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void CreateInstance_CreateNewInstanceOfOrder_Order()
    {
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_GetInstanceTitle_string()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      // Act
      string result = newOrder.Title;
      // Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_GetInstanceDescription_string()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      // Act
      string result = newOrder.Description;
      // Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_GetInstancePrice_string()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      // Act
      int result = newOrder.Price;
      // Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_GetInstanceDate_string()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      // Act
      string result = newOrder.Date;
      // Assert
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetId_GetInstanceId_string()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      // Act
      int result = newOrder.Id;
      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_FindInstanceById_Order()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      string title2 = "Weekday";
      string description2 = "Two dozen croissants";
      int price2 = 20;
      string date2 = "December 20, 2022";
      Order newOrder2 = new Order(title2, description2, price2, date2);

      // Act
      Order foundOrder = Order.Find(2);

      // Assert
      Assert.AreEqual(newOrder2, foundOrder);
    }

    [TestMethod]
    public void GetAll_GetAllInstancesOfOrder_List()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      string title2 = "Weekday";
      string description2 = "Two dozen croissants";
      int price2 = 20;
      string date2 = "December 20, 2022";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder, newOrder2 };
      
      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Delete_DeleteInstanceOfOrder_List()
    {
      // Arrange
      string title = "Weekend";
      string description = "Four dozen croissants";
      int price = 40;
      string date = "December 16, 2022";
      Order newOrder = new Order(title, description, price, date);
      string title2 = "Weekday";
      string description2 = "Two dozen croissants";
      int price2 = 20;
      string date2 = "December 20, 2022";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder2 };
      
      // Act
      Order.Delete(newOrder);
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}