-- Using the customer_db database
USE customer_db;


-- Insert in customers
INSERT INTO customers (id, name, email)
VALUES
    ('62e44498-c817-417b-91b6-9ab2e691e2e5', 'John Doe', 'john.doe@example.com'),
    ('a4a25edc-22d0-492e-96df-c5f31037f38c', 'Jane Smith', 'jane.smith@example.com');

-- Insert in addresses
INSERT INTO addresses (id, street, city, state, postalCode, country, customerId)
VALUES
    ('555d0ed5-9292-4683-9f2a-8a542b77d852', '123 Main Street', 'Cityville', 'Stateville', '12345', 'Countryland', '62e44498-c817-417b-91b6-9ab2e691e2e5'),
    ('e8cec812-e543-41ae-84f4-c6d8252b7a00', '456 Elm Avenue', 'Townsville', 'Countyville', '67890', 'Countryland', 'a4a25edc-22d0-492e-96df-c5f31037f38c');