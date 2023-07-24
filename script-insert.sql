-- Using the customer_db database
USE customer_db;


-- Insert in customers
INSERT INTO customers (id, name, email)
VALUES
    ('ba7991a3-22c3-473b-8421-676b714c2181', 'John Doe', 'john.doe@example.com'),
    ('8bc247b0-bfa8-44d9-b1ff-0533655d74c9', 'Jane Smith', 'jane.smith@example.com'),
    ('81f4a9ef-2cc3-422d-89fd-6ba7c4a5fda3', 'David D. Clifford', 'david.cli@example.com');

-- Insert in addresses
INSERT INTO addresses (id, street, city, state, postalCode, country, customerId)
VALUES
    ('b41a07a6-6cfc-4195-8579-c6bf0b605ea1', '2592 Boundary Street', 'Jacksonville', 'Florida', '32202', 'USA', 'ba7991a3-22c3-473b-8421-676b714c2181'),
    ('6b155fb2-3be8-4fdc-8c00-947670d28644', '456 Elm Avenue', 'Hythe', 'Alberta', '67890', 'Canada', '8bc247b0-bfa8-44d9-b1ff-0533655d74c9'),
    ('a432b04c-c380-46f9-bbc2-7b68240c557d', '1224 James Martin Circle', 'Columbus', 'Ohio', '43212', 'USA', '81f4a9ef-2cc3-422d-89fd-6ba7c4a5fda3');