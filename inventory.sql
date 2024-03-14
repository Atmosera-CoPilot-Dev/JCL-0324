-- Database application: MySql
-- Purpose: This file contains the SQL statements for querying and altering an existing database named 'inventory'.
-- Assumptions and Limitations: The database is already created and the user has the necessary permissions to execute the SQL statements.

-- Generate the command to show all tables in the database
SHOW TABLES;

-- create a table named 'categories' if it does not exist. The table will have the following columns:
-- id (auto-incremented integer), name (string), description (string)
CREATE TABLE IF NOT EXISTS categories (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  description VARCHAR(255)
);

-- Create a table named 'products' if it does not exist. The table will have the following columns:
-- id (auto-incremented integer), name (string), price (decimal)
-- and a foreign key 'category_id' that references the 'id' column in the 'categories' table.
CREATE TABLE IF NOT EXISTS products (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  price DECIMAL(10, 2) NOT NULL,
  category_id INT,
  FOREIGN KEY (category_id) REFERENCES categories(id)
);


-- insert random data into the 'categories' table
INSERT INTO categories (name, description) VALUES ('Electronics', 'Electronic devices and accessories');
INSERT INTO categories (name, description) VALUES ('Clothing', 'Clothing and fashion accessories');
INSERT INTO categories (name, description) VALUES ('Books', 'Books and reading materials');

-- insert random data into the 'products' table

INSERT INTO products (name, price, category_id) VALUES ('Laptop', 999.99, 1);
INSERT INTO products (name, price, category_id) VALUES ('Smartphone', 499.99, 1);
INSERT INTO products (name, price, category_id) VALUES ('T-shirt', 19.99, 2);
INSERT INTO products (name, price, category_id) VALUES ('Jeans', 39.99, 2);
INSERT INTO products (name, price, category_id) VALUES ('Novel', 9.99, 3);

-- Query to retrieve all products and their categories
SELECT p.name AS product_name, p.price AS product_price, c.name AS category_name

-- Query to display the highest priced product
SELECT name AS product_name, price AS product_price
FROM products
ORDER BY price DESC
LIMIT 1;


