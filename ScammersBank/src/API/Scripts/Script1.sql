CREATE TABLE IF NOT EXISTS public.users
(
    user_id integer NOT NULL DEFAULT nextval('users_user_id_seq'::regclass),
    user_name character varying COLLATE pg_catalog."default" NOT NULL,
    user_address character varying COLLATE pg_catalog."default" NOT NULL,
    user_account_1 integer,
    user_account_2 integer,
    user_is_deleted boolean NOT NULL,
    CONSTRAINT users_pkey PRIMARY KEY (user_id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.users
    OWNER to postgres;