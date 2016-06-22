# CustomerManagement
CS129L Final Project

A customer records management program capable of storing, editing, and deleting both customer and transactions records. This
project implements designs patterns and other object oriented programming concepts ([See below](#concept)).
This repository has dependencies. It requires [CustomerRecords](https://github.com/alexako/CustomerRecords) (found [here](https://github.com/alexako/CustomerRecords)) and [ObjectListView](http://objectlistview.sourceforge.net/cs/gettingStarted.html).

####Group Members
+ Sydney Adalin
+ Li Cuña
+ Mira Dela Cruz
+ Alex Reyes
+ Bea Vallespin

###Concept
The overall design of the project was influenced by the Model-View-Controller concept. A `RequestHandler` is required to create a new record or access existing records and acts as the controller. This causes all interactions with the records and data objects to be centralized and, therefore, avoids spaghetti code (Mediator Design Pattern). All activity involving the records is handled by the `RequestHandler`.

![Concept diagram][mvcdiagram]

A Singleton design pattern was implemented in the `Record` class and acts as the model. Maintaining a single `Record`
instance at all times provides the assurance of a single data set and prevents conflicting records.

```csharp
//Record.cs

/* Singleton pattern */
private static Record theInstance = null;
private Record() {
    _customers = new Dictionary<string, Customer>();
    _transactions = new Dictionary<string, Transaction>();
    loadShoppingMenuItems();
}

public static Record getInstance()
{ //Assures only one instance of the Record class exists
    if (theInstance == null)        //If there is no Record instance 
        theInstance = new Record(); //instantiate here, otherwise do nothing

    return theInstance;
}
```

This repository contains all of the UI forms and acts as the View. It doesn't contain any data objects. See the other code [here](https://github.com/alexako/CustomerRecords).

###Classes and Data Structures
The `Record` class contains two dictionaries `customers` and `transactions`. The key is the [unique ID](#uniqueid) each object has and
the value is the object itself.

```csharp
//{ "[CustomerID]" : customerObject }
Dictionary<string, Customer> customers = { "C20160621085326" : customer }
//{ "[TransactionID + CustomerID]" : transactionObject }
Dictionary<string, Transaction> transactions = { "T20160616081131C20160621085326" : transaction }
```

####Customer Class
```csharp
//Customer.cs
public Customer(string fname, string lname, string email, string phone, Address addr)
{
    this._customer_id = generateID(); //Generates ID based on current date and time (YYYYMMDDHHmmSS)
    this._first_name = fname;
    this._last_name = lname;
    this._email = email;
    this._phone_number = phone;
    this._address = addr;
}

//No methods here
```

####Address Class
```csharp
//Address.cs
public Address (string address1, string address2, string city, string  province, string country)
{
    this._addr1 = address1;
    this._addr2 = address2;
    this._city = city;
    this._province = province;
    this._country = country;
}

//No methods here
```

####Transaction Class
```csharp
//Transaction.cs
public Transaction(string customer_id)
{
    _customer_id = customer_id;
    _trans_id = generateID(); //Generates ID based on current date and time + the corresponding customer's ID
    _date_of_trans = DateTime.Now.ToString();
    _shopping_cart = new Dictionary<string, int>();
}

//No methods here either
```

####Record Class
The `Record` class stores all the objects. That's pretty much it. It has 4 methods: `add` customer or transaction, `delete` customer or transaction, `getCustomer(string customer_id)` which returns a customer object, and `getTransactions(string customer_id)` which returns a list of transaction objects. The `add` and `delete` methods are overloaded. 

####RequestHandler Class
The `RequestHandler` class handles all of the operations. It receives requests to create new customers and transactions and adds them to the record. It also processes requests from the View and delivers it to the forms (e.g. ListView).
```csharp
//RequestHandler.cs

//Some methods of RequestHandler are:
//Process new transaction request
public Transaction createNewTransaction(Customer customer)
{
    return new Transaction(customer.customer_id);
}

//Return a customer based on a given customer_id
public Customer getCustomer(string customer_id)
{
    if (record.customers.ContainsKey(customer_id))
        return record.customers[customer_id];
    else
        return null;
}
... etc.
```


####UniqueID
Each `customer` and `transaction` object has a unique ID generated at instatiation. The `customerID` is composed of the complete date and time of creation to assure its uniqueness. The `transactionID` is a composition of a transaction's creation date and time to its respective customer's ID. This provides a relationship between the `transaction` and `customer` objects in the records.
```csharp
If a customer was created on June 18, 2016 at 2:18:16PM, its customer ID would be: C20160618141816
If this customer has a transaction on June 20, 2016 at 11:33:24AM, its transaction ID would be: T20160620113324C20160618141816
```

[mvcdiagram]: http://i.imgur.com/o73Q71Z.png?1
