create table companies
(
    id              serial
        constraint companies_pk_id
            primary key,
    social_name     varchar not null,
    company_name    varchar,
    document_number varchar,
    address         varchar
);

alter table companies
    owner to companyapi;

create table products
(
    id          serial
        constraint products_pk_id
            primary key,
    name        varchar not null,
    type        varchar,
    description integer,
    price       varchar,
    stock       integer not null
);

alter table products
    owner to companyapi;

