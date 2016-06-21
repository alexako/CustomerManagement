# CustomerManagement
CS129L Final Project

A customer records management program capable of storing, editing, and deleting both customer and transactions records. This
project implements designs patterns and other object oriented programming concepts. [See below](#concept).
This repository has dependencies. It requires [CustomerRecords](https://github.com/alexako/CustomerRecords) project (found [here](https://github.com/alexako/CustomerRecords)) and [ObjectListView](http://objectlistview.sourceforge.net/cs/gettingStarted.html).

####Group Members
+ Sydney Adalin
+ Li Cuña
+ Mira Dela Cruz
+ Alex Reyes
+ Bea Vallespin

###Concept
The overall design of the project was influenced by the Model-View-Controller concept. A `RequestHandler` is required to create a new record or access existing records and acts as the controller. This causes all interactions with the records and data objects to be centralized and, therefore, avoids spaghetti code (Mediator Design Pattern). All activity involving the records is handled by the `RequestHandler`.

A Singleton design pattern was implemented in the `Record` class and acts as the model. Maintaining a single `Record`
instance at all times provides the assurance of a single data set and prevents conflicting records.

This repository contains all of the UI forms and acts as the View. See more [here](https://github.com/alexako/CustomerRecords).

###Classes and Data Structures
The `Record` class contains two dictionaries `customers` and `transactions`. The key is the [unique ID](#uniqueid) each object has and
the value is the object itself.


####UniqueID
Each `customer` and `transaction` object has a unique ID generated at instatiation. The `customerID` is composed of the complete date and
time of creation to assure its uniqueness. The `transactionID` is a composition of the transaction's creation date and time concatenated
to its respective customer's ID. This provides a relationship between the `transaction` and `customer` objects in the records.
