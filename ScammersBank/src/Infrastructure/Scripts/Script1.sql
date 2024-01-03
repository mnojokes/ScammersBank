CREATE TABLE IF NOT EXISTS public.users
(
    id SERIAL PRIMARY KEY,
    name VARCHAR NOT NULL,
    address VARCHAR NOT NULL,
    "isDeleted" BOOLEAN NOT NULL DEFAULT false
);
