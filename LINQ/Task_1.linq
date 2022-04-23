<Query Kind="Statements">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c12aaaaa</ID>
    <NamingService>2</NamingService>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\ChinookDemoDb.sqlite</AttachFileName>
    <DisplayName>Demo database (SQLite)</DisplayName>
    <DriverData>
      <PreserveNumeric1>true</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.Sqlite</EFProvider>
      <MapSQLiteDateTimes>true</MapSQLiteDateTimes>
      <MapSQLiteBooleans>true</MapSQLiteBooleans>
    </DriverData>
  </Connection>
</Query>

//a
var names = new [] {"Vadon Enikő", "Bolyki Balázs", "Toronya Bertalan", "Polonkai Dávid", "Fazekas Levente", "Német Viktor"};
//b
names.Dump("Task B");
//c
names.OrderByDescending(x => x.Split()[0]).Select(x => x.Split(" ")[1]).Dump("Task C");
//d
names.Where(x => x.Contains("L") || x.Contains("l")).Count().Dump("Task D");
//e
names.Where(x => x.Split(" ")[0].Length > 5).Select(x => x.Split(" ")[1]).Dump("Task E");