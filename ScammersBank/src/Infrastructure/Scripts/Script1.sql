CREATE TABLE IF NOT EXISTS public.users
(
    user_id SERIAL PRIMARY KEY,
    user_name VARCHAR NOT NULL,
    user_address VARCHAR NOT NULL,
    user_account_1 INTEGER,
    user_account_2 INTEGER,
    user_is_deleted BOOLEAN NOT NULL DEFAULT false
);
