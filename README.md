# CustomerManagement
CS129L Final Project

A customer records management program capable of storing, editing, and deleting both customer and transactions records. This
project implements designs patterns (e.g. Singleton pattern) and other object oriented programming concepts. [See below](#concept).


###Concept
A Singleton design pattern was implemented for the `Record` class in order to prevent conflicting merges. Maintaining a single `Record`
instance provides the ability to easily access and update the records from anywhere in the program.

###Classes and Data Structures
The `Record` class contains two dictionaries `customers` and `transactions`. The key is the [unique ID](#uniqueid) each object has and
the value is the object itself.

####Customer Class

####Transaction Class

####UniqueID
Each `customer` and `transaction` object has a unique ID generated at instatiation. The `customerID` is composed of the complete date and
time of creation to assure its uniqueness. The `transactionID` is a composition of the transaction's creation date and time concatenated
to its respective customer's ID. This provides a relationship between the `transaction` and `customer` objects in the records.
