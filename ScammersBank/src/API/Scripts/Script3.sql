CREATE TABLE IF NOT EXISTS public.transactions
(
    transaction_id integer NOT NULL DEFAULT nextval('transactions_transaction_id_seq'::regclass),
    transaction_account_id integer NOT NULL,
    transaction_type integer NOT NULL,
    transaction_amount numeric NOT NULL,
    transaction_fees numeric NOT NULL,
    transaction_notes character varying COLLATE pg_catalog."default" NOT NULL,
    transaction_is_deleted boolean NOT NULL,
    CONSTRAINT transactions_pkey PRIMARY KEY (transaction_id),
    CONSTRAINT account_id FOREIGN KEY (transaction_account_id)
        REFERENCES public.accounts (account_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.transactions
    OWNER to postgres;