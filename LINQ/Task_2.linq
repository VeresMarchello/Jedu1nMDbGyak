<Query Kind="Statements" />

//a
List<int> numbers = new(){0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
//b
numbers.Where(x => x % 2 == 0).Select(x => x * x).Dump("Task B");
//c
numbers.Average().Dump("Task C");
//d
numbers.Where(x => x > numbers.Average()).Select(x => new {x, Diff = Math.Abs(x - numbers.Average())}).Dump("Task D");
//e
numbers.GroupBy(x => Math.Abs(x - numbers.Average())).Dump("Task E");
