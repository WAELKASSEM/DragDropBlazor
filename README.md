# BlazorDrag and Drop List
A Blazor component that supports drag and drop of elements. 
Tested on Web Assembly. 
## Main Features ##
1. Nesting Mutliple Lists.
2. Support of Dragging Data from other components.
3. Polymorphism Support.

Continue reading to discover more features.

## Getting Started ##
Install the Package using PM :

`Install-Package WK.Blazor.DragDrop -Version 1.0.0`

In the **Program.cs** Add the following namespace:

```csharp
using DragDrop.Blazor;
```

In the **Program.cs** Add the following line in the main function:

```chsarp
builder.Services.AddSingleton<DragDropService>();
```

## DragDropList Component
### Usage

```aspx
@using DragDrop.Blazor
<DragDropList></DragDropList>
```
### Parameters
1. **TItem** *(Type Parameter)*: The Type of the Items in the List.
2. **Items** *(IList<TItem)*: The List of Items. Default value is of Type : List<TItem>.
3. **Capacity** *(integer)*: The number of items the list can hold. **Evaluated on a Drop Event only**. Modifying the List from outside the component isn't checked. Default value is : int.MaxValue.
4. **OnCapacityReachedRejection** *(Event Callback<TItem>)*: Event Callback with the rejected item as argument.
5. **OnItemAdded** *(Event Callback<TItem>)*: Event Callback with last **added** item as argument. Modifying the List from outside the component isn't checked.
6. **DefaultDropMode** *(DefaultDrop enum)*: DefaultDrop.Start : When an Item is Dropped on the **List Itself**, it is added on the top of the List. DefaultDrop.End : When an Item is Dropped on the **List Itself**, it is added at the end of the List. Default value is DefaultDrop.End .
7. **AllowsDrag** *(bool)*: A boolean that allows dragging of the **Elements** with a default value of true. Drag Items inside of the list to swap positions. Drag Items Outside of the list to perform a cut/copy.
8. **Copy** *(Func<TItem, TItem>)*: A Function that tells the component how to copy items if they're dragged. When not set, Items dragged outside the list will be Cut. Parameter : Dragged Item. Return Value : Copy of Dragged Item.
9. **ItemTemplate** *(RenderFragment<TItem>)*: A render fragment to display each item.
10. **ItemTemplateClass** *(string)*: The CSS class of the ItemTemplate.
11. **EmptyView** *(RenderFragment)*: A render fragment to display when the list is empty.
12. **Verify** *(Func<TItem, bool>)*: A function to add extra verification before dropping an Item. When Verify returns True, the Item will be Added.
13. **OnRejected** *(Event Callback<TItem>)*: An Event Callback with the Item (that didn't pass the Verify test) as Argument.
14. **OnItemSwap** (*Event Callback*<Tuple<int,int>>): An Event Callback with a Tuple : Item **a** was swapped with an item **b**. So a has moved from the index **tuple.FirstItem** to **tuple.SecondItem**.

**You can add other html attributes, and of you course you can change the DragDropList Css.**

## DragDropService
### Usage

```aspx
@using DragDrop.Blazor
@inject DragDropService DD
```
### Methods
1. **SetData(object o)**: Sets the dragged data(if you wish to drag data from outside of the list).
2. **Clear()**: Clears the dragged data. In case you needed it.

## Samples

Samples Project can be found here. It is advised to take a look at them before starting.

[Samples Project](https://github.com/WAELKASSEM/DragDropBlazor/tree/master/DragDrop.Blazor.Samples)




## Dragging Data from other sources
You can do the following

```htmlmixed
<div draggable="true" @ondragstart="()=>DD.SetData(new Object())"></div>
```

<img src="Documentation\ExternalSource.gif" style="zoom:80%;" />

## Nesting

<img src="Documentation\Nesting.gif" style="zoom:80%;" />

## Polymorphism and Copy

<img src="Documentation\PolymorphismCopy.gif" style="zoom:80%;" />