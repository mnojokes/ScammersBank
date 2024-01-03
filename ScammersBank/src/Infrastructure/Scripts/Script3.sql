CREATE TABLE IF NOT EXISTS public.transactions
(
    id SERIAL PRIMARY KEY,
    "accountId" INTEGER NOT NULL,
    type INTEGER NOT NULL,
    amount NUMERIC NOT NULL,
    fees NUMERIC NOT NULL,
    notes VARCHAR NOT NULL,
    "isDeleted" BOOLEAN NOT NULL DEFAULT false,
    CONSTRAINT account_id FOREIGN KEY ("accountId")
        REFERENCES public.accounts (id)
        ON UPDATE CASCADE
        ON DELETE SET DEFAULT
);
