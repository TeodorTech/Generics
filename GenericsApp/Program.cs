using GenericsApp;


var intStack = new GenericStack<int>();
intStack.SetItemAtIndex(7,2);
intStack.SetItemAtIndex(8,3);
intStack.SetItemAtIndex(9,6);
intStack.SetItemAtIndex(10,8);
intStack.SwapItemsByIndex(10, 8);
intStack.SwapItemsByValue(7, 9);
intStack.SwapItems(2, 10);

for (int i = 0; i <= 9; i++)
{
    Console.WriteLine(intStack.GetItemByIndex(i));
}

/*// In the scenario where we dont use a for, we want to get an individual item 
//we need to maek sure that the searched item is in the range of the array
try
{
    Console.WriteLine(intStack.GetItemByIndex(11));
}
catch
{
    Console.WriteLine("Index too big");
}*/

