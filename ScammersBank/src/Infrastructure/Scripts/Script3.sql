CREATE TABLE IF NOT EXISTS public.transactions
(
    transaction_id SERIAL PRIMARY KEY,
    transaction_account_id INTEGER NOT NULL,
    transaction_type INTEGER NOT NULL,
    transaction_amount NUMERIC NOT NULL,
    transaction_fees NUMERIC NOT NULL,
    transaction_notes VARCHAR NOT NULL,
    transaction_is_deleted BOOLEAN NOT NULL DEFAULT false,
    CONSTRAINT account_id FOREIGN KEY (transaction_account_id)
        REFERENCES public.accounts (account_id)
        ON UPDATE CASCADE
        ON DELETE SET DEFAULT
);
