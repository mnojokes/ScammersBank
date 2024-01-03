CREATE TABLE IF NOT EXISTS public.accounts
(
    id SERIAL PRIMARY KEY,
    type INTEGER NOT NULL,
    balance NUMERIC NOT NULL,
    "holderId" INTEGER NOT NULL,
    "isClosed" BOOLEAN NOT NULL DEFAULT false,
    CONSTRAINT account_holder FOREIGN KEY ("holderId")
        REFERENCES public.users (id)
        ON UPDATE CASCADE
        ON DELETE SET DEFAULT
);
