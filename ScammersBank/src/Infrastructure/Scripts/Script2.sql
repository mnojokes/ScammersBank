CREATE TABLE IF NOT EXISTS public.accounts
(
    account_id SERIAL PRIMARY KEY,
    account_type INTEGER NOT NULL,
    account_balance NUMERIC NOT NULL,
    account_holder_id INTEGER NOT NULL,
    account_is_closed BOOLEAN NOT NULL DEFAULT false,
    CONSTRAINT account_holder FOREIGN KEY (account_holder_id)
        REFERENCES public.users (user_id)
        ON UPDATE CASCADE
        ON DELETE SET DEFAULT
);
