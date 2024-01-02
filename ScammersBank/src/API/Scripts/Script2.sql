CREATE TABLE IF NOT EXISTS public.accounts
(
    account_id integer NOT NULL DEFAULT nextval('accounts_account_id_seq'::regclass),
    account_type integer NOT NULL,
    account_balance numeric NOT NULL,
    account_holder_id integer NOT NULL,
    account_is_closed boolean NOT NULL,
    CONSTRAINT accounts_pkey PRIMARY KEY (account_id),
    CONSTRAINT account_holder FOREIGN KEY (account_holder_id)
        REFERENCES public.users (user_id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.accounts
    OWNER to postgres;