### 1. What database models do you know?
* `Hierarchical (tree) model` - this model organizes data in tree-like structure. One of the rules of a hierarchical database is that a parent can have multiple children, but a child can only have one parent. For example, think of an online store that sells many different products. The entire product catalog would be the parent, and the various types of products, such as books, electronics, etc., would be the children.
* `Network (graph) model` - in a network DBMS every data item can be related to many others ones. The database structure is like a graph. This is similar to the hierarchical model and also provides a tree-like structure. However, a child is allowed to have more than one parent. In the example of the product catalog, a book could fall into more than one category. The structure of a network database becomes more like a cobweb of connected elements.
* `Relational (table) model` - in a relational DBMS all data are organized in the form of tables.  In a table, each row represents a record, also referred to as an entity. Each column represents a field, also referred to as an attribute of the entity.
* `Object-oriented model` -  Data is stored as objects and can be interpreted only using the methods specified by its class. The relationship between similar objects is preserved (inheritance) as are references between objects. Queries can be faster because joins are often not needed (as in a relational database). This is because an object can be retrieved directly without a search, by following its object id. 

### 2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
* data dictionary management, data storage management, data transformation and presentation, security management, multiuser access control, backup and recovery management, data integrity management, database access languages and application programming interfaces, database communication interfaces, and transaction management

### 3. Define what is "table" in database terms.
* In database terms, a table is responsible for storing data in the database. Database tables consist of rows and columns.
* A row contains each record in the table, and the column is responsible for defining the type of data that goes into each cell.

### 4. Explain the difference between a primary and a foreign key
* A table can have `multiple foreign keys`. However, a table can have `only one primary key`.
* Primary keys enforce uniqueness on the column(s) of one table, foreign keys define a relationship between two tables. A foreign key identifies a column or group of columns in one (referencing) table that refers to a column or group of columns in another (referenced) table

### 5. Explain the different kinds of relationships between tables in relational databases
* One-to-one: Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table. In the absence of such a rule, you can usually combine both tables into one table without breaking any normalization rules.
* One-to-many: The primary key table contains only one record that relates to none, one, or many records in the related table. This relationship is similar to the one between you and a parent. You have only one mother, but your mother may have several children.
* Many-to-many: Each record in both tables can relate to any number of records (or no records) in the other table. For instance, if you have several siblings, so do your siblings (have many siblings). Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.

### 6. When is a certain database schema normalized? What are the advantages of normalized databases?
* Normalization of the relational schema removes repeating data
* Provide indexing
* Minimize modification anomalies
* Reduce table/row size

### 7. What are database integrity constraints and when are they used?
* Integrity constraints are a set of data validation rules that you can specify in order to restrict the data values that can be stored for a variable in a SAS data file. Integrity constraints help you preserve the validity and consistency of your data. SAS enforces the integrity constraints when the values associated with a variable are added, updated, or deleted.
* Check - limits the data values of variables to a specific set, range, or list of values
* Not null - requires that a variable contain a data value. Null (missing) values are not allowed.
* Unique, primary and foreign key validation

### 8. Point out the pros and cons of using indexes in a database.
* (+) Indices speed up searching of values in a certain column or group of columns
* (-) Indices should be used for big tables only (e.g. 50 000 rows)
* (-) Adding and deleting records in indexed tables is slower

### 9. What's the main purpose of the SQL language?
*  It is a standard programming language used in the management of data stored in a relational database management system. It supports distributed databases, offering users great flexibility.

### 10. What are transactions used for? Give an example.
* Transactions are a sequence of database operations which are executed as a single unit: Either all of them execute successfully or none of them is executed at all
* Example: A bank transfer from one account into another (withdrawal + deposit)
If either the withdrawal or the deposit fails the entire operation should be cancelled

### 11. What is a NoSQL database?
* A NoSQL database environment is, simply put, a non-relational and largely distributed database system that enables rapid, ad-hoc organization and analysis of extremely high-volume, disparate data types. NoSQL databases are sometimes referred to as cloud databases, non-relational databases, big Data databases.

### 12. Explain the classical non-relational data models.
* Document model (e.g. MongoDB, CouchDB) - Set of documents, e.g. JSON strings
* Key-value model (e.g. Redis) - Set of key-value pairs
* Hierarchical key-value - Hierarchy of key-value pairs
* Wide-column model (e.g. Cassandra) - Key-value model with schema
* Object model (e.g. Cache) - Set of OOP-style objects

### 13. Give few examples of NoSQL databases and their pros and cons.
* `MongoDB` - if we have an application that performs a lot of read but less write
* `Redis` - exceptionally fast, supports rich data types, operations are atomic
* `Cassandra` - ability to access and deliver data in near real-time, ability to deploy across data centers