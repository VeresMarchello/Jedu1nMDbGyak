<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c394</ID>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AttachFile>true</AttachFile>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <DisplayName>Nutshell</DisplayName>
    <DriverData>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

var dbContext = this;

//a & b
Customers.Dump("Customers");
Customers.Count().Dump("Count");
Customers.Single(c => c.ID == 2).Dump("ID 2");
//Customers.Single(c => c.Customerd == 2).Dump();

//c & d
dbContext.Customers.Count().Dump("Count");

Customer customer = new Customer()
{
	ID = 10,
	Name = "Thomas"
};

//dbContext.Customers.Add(customer);
//dbContext.SaveChanges();

//dbContext.Customers.Count().Dump("Count");

//dbContext.Customers.Remove(customer);
dbContext.SaveChanges();

//dbContext.Customers.Count().Dump("Count");

//e
customer.Name = "Thomas";
dbContext.SaveChanges();

Customers.Single(x => x.ID == customer.ID).Dump("Task E");

//f
Customers.Join(Purchases, c => c.ID, p => p.CustomerID, (c, p) => new {c.Name, p.Description, p.Price}).Dump("Task F");	

//g
/*from c in Customers
join p in Purchases on c.ID equals p.CustomerID
select new
{
	c.Name, 
	p.Description,
	p.Price
}*/


