PGDMP     (    (    
            {            usersdb    14.2    14.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16872    usersdb    DATABASE     d   CREATE DATABASE usersdb WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Russian_Russia.1251';
    DROP DATABASE usersdb;
                postgres    false            �          0    25186 
   admin_prof 
   TABLE DATA           B   COPY public.admin_prof ("Логин", "Пароль") FROM stdin;
    public          postgres    false    212   1       �          0    25116    spisok_technik 
   TABLE DATA             COPY public.spisok_technik (id, "Тип_техники", "Наименование_техники", "Дата_установки", "Кабинет", "Сотрудник", "Серийный_номер", "Количество", "Наличие", "Ремонт") FROM stdin;
    public          postgres    false    211   N       �          0    16874    userss 
   TABLE DATA           F   COPY public.userss (id, login, password, name, preoritet) FROM stdin;
    public          postgres    false    210   �       �           0    0    Users_Id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."Users_Id_seq"', 6, true);
          public          postgres    false    209            �      x������ � �      �   r   x�3估��.6*�p:���C] 2200��%F��3fɅ	v_�
�`�콰�b��v �/l��raM,�t�h6��M40�*��.#�?\�+F��� ��w�      �   [   x�3�LL��̃�!���1~\F���)i霅�E%����E� acδ��4�\"L�	gJZVFzgqJF&\�)g"��9fP�c� �+F��� w_!�     