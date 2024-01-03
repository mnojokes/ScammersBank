CREATE TABLE IF NOT EXISTS public.users
(
    id SERIAL PRIMARY KEY,
    name VARCHAR NOT NULL,
    address VARCHAR NOT NULL,
    account1 INTEGER,
    account2 INTEGER,
    "isDeleted" BOOLEAN NOT NULL DEFAULT false
);
