create table companies
(
    id              serial
        constraint companies_pk_id
            primary key,
    social_name     varchar not null,
    company_name    varchar not null,
    document_number varchar not null,
    address         varchar not null
);

alter table companies
    owner to companyapi;

create table products
(
    id          serial
        constraint products_pk_id
            primary key,
    name        varchar not null,
    type        varchar not null,
    description integer not null,
    price       varchar not null,
    stock       integer not null
);

alter table products
    owner to companyapi;

