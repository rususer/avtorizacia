PGDMP         :    	            {            usersdb    14.2    14.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16872    usersdb    DATABASE     d   CREATE DATABASE usersdb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE usersdb;
                postgres    false            �            1259    25116    spisok_technik    TABLE     �  CREATE TABLE public.spisok_technik (
    id integer NOT NULL,
    "Тип_техники" character(100000),
    "Наименование_техники" character(100000),
    "Дата_установки" character(100000),
    "Кабинет" character(100000),
    "Сотрудник" character(100000),
    "Серийный_номер" character(100000),
    "Количество" integer,
    "Наличие" boolean
);
 "   DROP TABLE public.spisok_technik;
       public         heap    postgres    false            �          0    25116    spisok_technik 
   TABLE DATA              COPY public.spisok_technik (id, "Тип_техники", "Наименование_техники", "Дата_установки", "Кабинет", "Сотрудник", "Серийный_номер", "Количество", "Наличие") FROM stdin;
    public          postgres    false    211   j       _           2606    25122 "   spisok_technik spisok_technik_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.spisok_technik
    ADD CONSTRAINT spisok_technik_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.spisok_technik DROP CONSTRAINT spisok_technik_pkey;
       public            postgres    false    211            �      x������ � �     