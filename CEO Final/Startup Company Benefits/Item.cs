using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Startup_Company_Benefits
{
	//Our class Item
	public class Item
	{
		//Our variables
		string ItemName;
		float ItemPrice;
		int ItemQuantity;
		//Adds our Items to a list
		static List<Item> AddedItems = new List<Item>();
		//What our Items consists of 
		public Item()
		{
			ItemName = "";
			ItemPrice = 0.0f;
			ItemQuantity = 0;
		}
		//What our Items consists of 
		public Item(string newItemName, float newItemPrice, int newItemQuanity)
		{
			ItemName = newItemName;
			ItemPrice = newItemPrice;
			ItemQuantity = newItemQuanity;
		}
		//Function for adding our Items
		public void Add()
		{
			AddedItems.Add(this);
			Menu.Instance.ItemGrid.Rows.Add(ItemName, ItemQuantity, ItemPrice);
		}
		//Function for clearing our Items
		public static void Clear()
		{
			AddedItems.Clear();
			Menu.Instance.ItemGrid.Rows.Clear();
		}
		//Function for saving our Items
		public static void Save()
		{
			//Creates a file named Item Data
			using (var fileStream = File.CreateText("ItemData.txt"))
			{
				foreach (var item in AddedItems)
				{
					//Writes this info into our Item Data text file
					fileStream.WriteLine(item.ItemName);
					fileStream.WriteLine(item.ItemPrice);
					fileStream.WriteLine(item.ItemQuantity);
				}
				fileStream.Close();
			}
		}
		//Function for loading our items
		public static void Load()
		{
			//Looks at our item data text file
			if (File.Exists("ItemData.txt"))
			{
				using (var fileStream = File.OpenText("ItemData.txt"))
				{
					do
					{
						//If items have been saved they will be displayed
						Item newItem = new Item();

						newItem.ItemName = fileStream.ReadLine();
						newItem.ItemPrice = float.Parse(fileStream.ReadLine());
						newItem.ItemQuantity = int.Parse(fileStream.ReadLine());

						newItem.Add();
					}
					while (!fileStream.EndOfStream);
				}
			}
		}
		//A string function for getting item name
		public string GetItemName()
		{
			return ItemName;
		}
		//A function for setting item name
		public void SetItemName(string newItemName)
		{
			ItemName = newItemName;
		}
		//A function for getting item price
		public float GetItemPrice()
		{
			return ItemPrice;
		}
		//A function for setting item price
		public void SetItemPrice(float newItemPrice)
		{
			ItemPrice = newItemPrice;
		}
		//A function for getting item quantity
		public float GetItemQuantity()
		{
			return ItemQuantity;
		}
		//A function for setting item quantity
		public void SetItemQuanity(int newItemQuantity)
		{
			ItemQuantity = newItemQuantity;
		}
	}
}
