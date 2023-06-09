PGDMP         )                {            Test7    15.2    15.2 V    c           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            d           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            e           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            f           1262    26597    Test7    DATABASE     {   CREATE DATABASE "Test7" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Test7";
                postgres    false            �            1259    26598    Car    TABLE     J  CREATE TABLE public."Car" (
    "CarID" integer NOT NULL,
    "VIN" character varying(17),
    "StateNumber" character varying(9),
    "Stamp" character varying(200),
    "Model" character varying(200),
    "Mileage" integer,
    "NextMaintenance" integer,
    "Status" text,
    "LocationBase" integer,
    "DriverID" integer
);
    DROP TABLE public."Car";
       public         heap    postgres    false            �            1259    26603    Car_CarID_seq    SEQUENCE     �   CREATE SEQUENCE public."Car_CarID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public."Car_CarID_seq";
       public          postgres    false    214            g           0    0    Car_CarID_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public."Car_CarID_seq" OWNED BY public."Car"."CarID";
          public          postgres    false    215            �            1259    26604    CargoCategory    TABLE     �   CREATE TABLE public."CargoCategory" (
    "CategoryID" integer NOT NULL,
    "Name" character varying(200),
    "TransportationCoefficient" numeric(10,2),
    "Comments" character varying(500)
);
 #   DROP TABLE public."CargoCategory";
       public         heap    postgres    false            �            1259    26609    CargoСategory_CategoryID_seq    SEQUENCE     �   CREATE SEQUENCE public."CargoСategory_CategoryID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public."CargoСategory_CategoryID_seq";
       public          postgres    false    216            h           0    0    CargoСategory_CategoryID_seq    SEQUENCE OWNED BY     d   ALTER SEQUENCE public."CargoСategory_CategoryID_seq" OWNED BY public."CargoCategory"."CategoryID";
          public          postgres    false    217            �            1259    26610    Client    TABLE     =  CREATE TABLE public."Client" (
    "ClientID" integer NOT NULL,
    "Name" character varying(50),
    "Surname" character varying(50),
    "Patronymic" character varying(50),
    "Birthdate" date,
    "SeriaNumberPassport" character(10),
    "PhoneNumber" character varying(11),
    "Email" character varying(100)
);
    DROP TABLE public."Client";
       public         heap    postgres    false            �            1259    26613    Client_ClientID_seq    SEQUENCE     �   CREATE SEQUENCE public."Client_ClientID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."Client_ClientID_seq";
       public          postgres    false    218            i           0    0    Client_ClientID_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."Client_ClientID_seq" OWNED BY public."Client"."ClientID";
          public          postgres    false    219            �            1259    26614    DriverIdentification    TABLE       CREATE TABLE public."DriverIdentification" (
    "GuideReferencesID" integer NOT NULL,
    "DriverLicense" character(10),
    "B" boolean,
    "BE" boolean,
    "C" boolean,
    "CE" boolean,
    "DateReceipt" date,
    "TerminationDate" date,
    "EmployeeID" integer
);
 *   DROP TABLE public."DriverIdentification";
       public         heap    postgres    false            �            1259    26617 *   DriverIdentification_GuideReferencesID_seq    SEQUENCE     �   CREATE SEQUENCE public."DriverIdentification_GuideReferencesID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 C   DROP SEQUENCE public."DriverIdentification_GuideReferencesID_seq";
       public          postgres    false    220            j           0    0 *   DriverIdentification_GuideReferencesID_seq    SEQUENCE OWNED BY        ALTER SEQUENCE public."DriverIdentification_GuideReferencesID_seq" OWNED BY public."DriverIdentification"."GuideReferencesID";
          public          postgres    false    221            �            1259    26618    Employee    TABLE     �  CREATE TABLE public."Employee" (
    "EmployeeID" integer NOT NULL,
    "Password" text,
    "Name" character varying(50),
    "Surname" character varying(50),
    "Patronymic" character varying(50),
    "Birthdate" date,
    "SeriaNumberPassport" character varying(10),
    "PhoneNumber" character varying(11),
    "ResidentialAddress" character varying(200),
    "Email" character varying(100),
    "Post" character varying(200)
);
    DROP TABLE public."Employee";
       public         heap    postgres    false            �            1259    26623    Employee_EmployeeID_seq    SEQUENCE     �   CREATE SEQUENCE public."Employee_EmployeeID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."Employee_EmployeeID_seq";
       public          postgres    false    222            k           0    0    Employee_EmployeeID_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public."Employee_EmployeeID_seq" OWNED BY public."Employee"."EmployeeID";
          public          postgres    false    223            �            1259    26624    LocationBase    TABLE     �   CREATE TABLE public."LocationBase" (
    "LocationBaseID" integer NOT NULL,
    "Address" character varying(200),
    "NumberSeats" integer,
    "Region" character varying(200),
    "Director" integer
);
 "   DROP TABLE public."LocationBase";
       public         heap    postgres    false            �            1259    26627    LocationBase_LocationBaseID_seq    SEQUENCE     �   CREATE SEQUENCE public."LocationBase_LocationBaseID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 8   DROP SEQUENCE public."LocationBase_LocationBaseID_seq";
       public          postgres    false    224            l           0    0    LocationBase_LocationBaseID_seq    SEQUENCE OWNED BY     i   ALTER SEQUENCE public."LocationBase_LocationBaseID_seq" OWNED BY public."LocationBase"."LocationBaseID";
          public          postgres    false    225            �            1259    26628    Package    TABLE     L  CREATE TABLE public."Package" (
    "PackageID" integer NOT NULL,
    "ClientID" integer,
    "Comments" character varying(500),
    "SendingAddress" integer,
    "DeliveryAddress" integer,
    "Weight" numeric(10,2),
    "DateAcceptance" timestamp without time zone,
    "DateDeliveryToPoint" timestamp without time zone,
    "DateIssue" timestamp without time zone,
    "EmployeeID" integer,
    "Length" integer,
    "Width" integer,
    "Height" integer,
    "PackageType" text,
    "DeliveryCost" numeric(10,2),
    "CargoCategory" integer,
    "Status" text,
    "CarID" integer
);
    DROP TABLE public."Package";
       public         heap    postgres    false            �            1259    26633    Package_PackageID_seq    SEQUENCE     �   CREATE SEQUENCE public."Package_PackageID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public."Package_PackageID_seq";
       public          postgres    false    226            m           0    0    Package_PackageID_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public."Package_PackageID_seq" OWNED BY public."Package"."PackageID";
          public          postgres    false    227            �            1259    26634    PointReception    TABLE     �   CREATE TABLE public."PointReception" (
    "PointID" integer NOT NULL,
    "Address" character varying(200),
    "Director" integer,
    "WarehouseID" integer
);
 $   DROP TABLE public."PointReception";
       public         heap    postgres    false            �            1259    26637    PointReception_PointID_seq    SEQUENCE     �   CREATE SEQUENCE public."PointReception_PointID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public."PointReception_PointID_seq";
       public          postgres    false    228            n           0    0    PointReception_PointID_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public."PointReception_PointID_seq" OWNED BY public."PointReception"."PointID";
          public          postgres    false    229            �            1259    26638 	   Warehouse    TABLE     �   CREATE TABLE public."Warehouse" (
    "WarehouseID" integer NOT NULL,
    "Address" character varying(200),
    "Region" character varying(200),
    "Director" integer
);
    DROP TABLE public."Warehouse";
       public         heap    postgres    false            �            1259    26641    Warehouse_WarehouseID_seq    SEQUENCE     �   CREATE SEQUENCE public."Warehouse_WarehouseID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."Warehouse_WarehouseID_seq";
       public          postgres    false    230            o           0    0    Warehouse_WarehouseID_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."Warehouse_WarehouseID_seq" OWNED BY public."Warehouse"."WarehouseID";
          public          postgres    false    231            �           2604    26642 	   Car CarID    DEFAULT     l   ALTER TABLE ONLY public."Car" ALTER COLUMN "CarID" SET DEFAULT nextval('public."Car_CarID_seq"'::regclass);
 <   ALTER TABLE public."Car" ALTER COLUMN "CarID" DROP DEFAULT;
       public          postgres    false    215    214            �           2604    26643    CargoCategory CategoryID    DEFAULT     �   ALTER TABLE ONLY public."CargoCategory" ALTER COLUMN "CategoryID" SET DEFAULT nextval('public."CargoСategory_CategoryID_seq"'::regclass);
 K   ALTER TABLE public."CargoCategory" ALTER COLUMN "CategoryID" DROP DEFAULT;
       public          postgres    false    217    216            �           2604    26644    Client ClientID    DEFAULT     x   ALTER TABLE ONLY public."Client" ALTER COLUMN "ClientID" SET DEFAULT nextval('public."Client_ClientID_seq"'::regclass);
 B   ALTER TABLE public."Client" ALTER COLUMN "ClientID" DROP DEFAULT;
       public          postgres    false    219    218            �           2604    26645 &   DriverIdentification GuideReferencesID    DEFAULT     �   ALTER TABLE ONLY public."DriverIdentification" ALTER COLUMN "GuideReferencesID" SET DEFAULT nextval('public."DriverIdentification_GuideReferencesID_seq"'::regclass);
 Y   ALTER TABLE public."DriverIdentification" ALTER COLUMN "GuideReferencesID" DROP DEFAULT;
       public          postgres    false    221    220            �           2604    26646    Employee EmployeeID    DEFAULT     �   ALTER TABLE ONLY public."Employee" ALTER COLUMN "EmployeeID" SET DEFAULT nextval('public."Employee_EmployeeID_seq"'::regclass);
 F   ALTER TABLE public."Employee" ALTER COLUMN "EmployeeID" DROP DEFAULT;
       public          postgres    false    223    222            �           2604    26647    LocationBase LocationBaseID    DEFAULT     �   ALTER TABLE ONLY public."LocationBase" ALTER COLUMN "LocationBaseID" SET DEFAULT nextval('public."LocationBase_LocationBaseID_seq"'::regclass);
 N   ALTER TABLE public."LocationBase" ALTER COLUMN "LocationBaseID" DROP DEFAULT;
       public          postgres    false    225    224            �           2604    26648    Package PackageID    DEFAULT     |   ALTER TABLE ONLY public."Package" ALTER COLUMN "PackageID" SET DEFAULT nextval('public."Package_PackageID_seq"'::regclass);
 D   ALTER TABLE public."Package" ALTER COLUMN "PackageID" DROP DEFAULT;
       public          postgres    false    227    226            �           2604    26649    PointReception PointID    DEFAULT     �   ALTER TABLE ONLY public."PointReception" ALTER COLUMN "PointID" SET DEFAULT nextval('public."PointReception_PointID_seq"'::regclass);
 I   ALTER TABLE public."PointReception" ALTER COLUMN "PointID" DROP DEFAULT;
       public          postgres    false    229    228            �           2604    26650    Warehouse WarehouseID    DEFAULT     �   ALTER TABLE ONLY public."Warehouse" ALTER COLUMN "WarehouseID" SET DEFAULT nextval('public."Warehouse_WarehouseID_seq"'::regclass);
 H   ALTER TABLE public."Warehouse" ALTER COLUMN "WarehouseID" DROP DEFAULT;
       public          postgres    false    231    230            O          0    26598    Car 
   TABLE DATA           �   COPY public."Car" ("CarID", "VIN", "StateNumber", "Stamp", "Model", "Mileage", "NextMaintenance", "Status", "LocationBase", "DriverID") FROM stdin;
    public          postgres    false    214   �q       Q          0    26604    CargoCategory 
   TABLE DATA           h   COPY public."CargoCategory" ("CategoryID", "Name", "TransportationCoefficient", "Comments") FROM stdin;
    public          postgres    false    216   r       S          0    26610    Client 
   TABLE DATA           �   COPY public."Client" ("ClientID", "Name", "Surname", "Patronymic", "Birthdate", "SeriaNumberPassport", "PhoneNumber", "Email") FROM stdin;
    public          postgres    false    218   er       U          0    26614    DriverIdentification 
   TABLE DATA           �   COPY public."DriverIdentification" ("GuideReferencesID", "DriverLicense", "B", "BE", "C", "CE", "DateReceipt", "TerminationDate", "EmployeeID") FROM stdin;
    public          postgres    false    220   �r       W          0    26618    Employee 
   TABLE DATA           �   COPY public."Employee" ("EmployeeID", "Password", "Name", "Surname", "Patronymic", "Birthdate", "SeriaNumberPassport", "PhoneNumber", "ResidentialAddress", "Email", "Post") FROM stdin;
    public          postgres    false    222   �r       Y          0    26624    LocationBase 
   TABLE DATA           j   COPY public."LocationBase" ("LocationBaseID", "Address", "NumberSeats", "Region", "Director") FROM stdin;
    public          postgres    false    224   �s       [          0    26628    Package 
   TABLE DATA             COPY public."Package" ("PackageID", "ClientID", "Comments", "SendingAddress", "DeliveryAddress", "Weight", "DateAcceptance", "DateDeliveryToPoint", "DateIssue", "EmployeeID", "Length", "Width", "Height", "PackageType", "DeliveryCost", "CargoCategory", "Status", "CarID") FROM stdin;
    public          postgres    false    226   �s       ]          0    26634    PointReception 
   TABLE DATA           [   COPY public."PointReception" ("PointID", "Address", "Director", "WarehouseID") FROM stdin;
    public          postgres    false    228   dt       _          0    26638 	   Warehouse 
   TABLE DATA           U   COPY public."Warehouse" ("WarehouseID", "Address", "Region", "Director") FROM stdin;
    public          postgres    false    230   �t       p           0    0    Car_CarID_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public."Car_CarID_seq"', 1, true);
          public          postgres    false    215            q           0    0    CargoСategory_CategoryID_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public."CargoСategory_CategoryID_seq"', 2, true);
          public          postgres    false    217            r           0    0    Client_ClientID_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."Client_ClientID_seq"', 1, true);
          public          postgres    false    219            s           0    0 *   DriverIdentification_GuideReferencesID_seq    SEQUENCE SET     Z   SELECT pg_catalog.setval('public."DriverIdentification_GuideReferencesID_seq"', 1, true);
          public          postgres    false    221            t           0    0    Employee_EmployeeID_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."Employee_EmployeeID_seq"', 1, true);
          public          postgres    false    223            u           0    0    LocationBase_LocationBaseID_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public."LocationBase_LocationBaseID_seq"', 1, true);
          public          postgres    false    225            v           0    0    Package_PackageID_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."Package_PackageID_seq"', 1, true);
          public          postgres    false    227            w           0    0    PointReception_PointID_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."PointReception_PointID_seq"', 2, true);
          public          postgres    false    229            x           0    0    Warehouse_WarehouseID_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."Warehouse_WarehouseID_seq"', 2, true);
          public          postgres    false    231            �           2606    26652    Car Car_VIN_key 
   CONSTRAINT     O   ALTER TABLE ONLY public."Car"
    ADD CONSTRAINT "Car_VIN_key" UNIQUE ("VIN");
 =   ALTER TABLE ONLY public."Car" DROP CONSTRAINT "Car_VIN_key";
       public            postgres    false    214            �           2606    26654    Car Car_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public."Car"
    ADD CONSTRAINT "Car_pkey" PRIMARY KEY ("CarID");
 :   ALTER TABLE ONLY public."Car" DROP CONSTRAINT "Car_pkey";
       public            postgres    false    214            �           2606    26656 !   CargoCategory CargoСategory_pkey 
   CONSTRAINT     m   ALTER TABLE ONLY public."CargoCategory"
    ADD CONSTRAINT "CargoСategory_pkey" PRIMARY KEY ("CategoryID");
 O   ALTER TABLE ONLY public."CargoCategory" DROP CONSTRAINT "CargoСategory_pkey";
       public            postgres    false    216            �           2606    26658    Client Client_Email_key 
   CONSTRAINT     Y   ALTER TABLE ONLY public."Client"
    ADD CONSTRAINT "Client_Email_key" UNIQUE ("Email");
 E   ALTER TABLE ONLY public."Client" DROP CONSTRAINT "Client_Email_key";
       public            postgres    false    218            �           2606    26660 %   Client Client_SeriaNumberPassport_key 
   CONSTRAINT     u   ALTER TABLE ONLY public."Client"
    ADD CONSTRAINT "Client_SeriaNumberPassport_key" UNIQUE ("SeriaNumberPassport");
 S   ALTER TABLE ONLY public."Client" DROP CONSTRAINT "Client_SeriaNumberPassport_key";
       public            postgres    false    218            �           2606    26662    Client Client_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public."Client"
    ADD CONSTRAINT "Client_pkey" PRIMARY KEY ("ClientID");
 @   ALTER TABLE ONLY public."Client" DROP CONSTRAINT "Client_pkey";
       public            postgres    false    218            �           2606    26664 ;   DriverIdentification DriverIdentification_DriverLicense_key 
   CONSTRAINT     �   ALTER TABLE ONLY public."DriverIdentification"
    ADD CONSTRAINT "DriverIdentification_DriverLicense_key" UNIQUE ("DriverLicense");
 i   ALTER TABLE ONLY public."DriverIdentification" DROP CONSTRAINT "DriverIdentification_DriverLicense_key";
       public            postgres    false    220            �           2606    26666 .   DriverIdentification DriverIdentification_pkey 
   CONSTRAINT     �   ALTER TABLE ONLY public."DriverIdentification"
    ADD CONSTRAINT "DriverIdentification_pkey" PRIMARY KEY ("GuideReferencesID");
 \   ALTER TABLE ONLY public."DriverIdentification" DROP CONSTRAINT "DriverIdentification_pkey";
       public            postgres    false    220            �           2606    26668    Employee Employee_Email_key 
   CONSTRAINT     ]   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_Email_key" UNIQUE ("Email");
 I   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_Email_key";
       public            postgres    false    222            �           2606    26670 )   Employee Employee_SeriaNumberPassport_key 
   CONSTRAINT     y   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_SeriaNumberPassport_key" UNIQUE ("SeriaNumberPassport");
 W   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_SeriaNumberPassport_key";
       public            postgres    false    222            �           2606    26672    Employee Employee_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public."Employee"
    ADD CONSTRAINT "Employee_pkey" PRIMARY KEY ("EmployeeID");
 D   ALTER TABLE ONLY public."Employee" DROP CONSTRAINT "Employee_pkey";
       public            postgres    false    222            �           2606    26674    LocationBase LocationBase_pkey 
   CONSTRAINT     n   ALTER TABLE ONLY public."LocationBase"
    ADD CONSTRAINT "LocationBase_pkey" PRIMARY KEY ("LocationBaseID");
 L   ALTER TABLE ONLY public."LocationBase" DROP CONSTRAINT "LocationBase_pkey";
       public            postgres    false    224            �           2606    26676    Package Package_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public."Package"
    ADD CONSTRAINT "Package_pkey" PRIMARY KEY ("PackageID");
 B   ALTER TABLE ONLY public."Package" DROP CONSTRAINT "Package_pkey";
       public            postgres    false    226            �           2606    26678 "   PointReception PointReception_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public."PointReception"
    ADD CONSTRAINT "PointReception_pkey" PRIMARY KEY ("PointID");
 P   ALTER TABLE ONLY public."PointReception" DROP CONSTRAINT "PointReception_pkey";
       public            postgres    false    228            �           2606    26680    Warehouse Warehouse_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public."Warehouse"
    ADD CONSTRAINT "Warehouse_pkey" PRIMARY KEY ("WarehouseID");
 F   ALTER TABLE ONLY public."Warehouse" DROP CONSTRAINT "Warehouse_pkey";
       public            postgres    false    230            �           2606    26681    Car Car_DriverID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Car"
    ADD CONSTRAINT "Car_DriverID_fkey" FOREIGN KEY ("DriverID") REFERENCES public."Employee"("EmployeeID");
 C   ALTER TABLE ONLY public."Car" DROP CONSTRAINT "Car_DriverID_fkey";
       public          postgres    false    222    3243    214            �           2606    26686    Car Car_LocationBase_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Car"
    ADD CONSTRAINT "Car_LocationBase_fkey" FOREIGN KEY ("LocationBase") REFERENCES public."LocationBase"("LocationBaseID");
 G   ALTER TABLE ONLY public."Car" DROP CONSTRAINT "Car_LocationBase_fkey";
       public          postgres    false    214    3245    224            �           2606    26691 9   DriverIdentification DriverIdentification_EmployeeID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."DriverIdentification"
    ADD CONSTRAINT "DriverIdentification_EmployeeID_fkey" FOREIGN KEY ("EmployeeID") REFERENCES public."Employee"("EmployeeID");
 g   ALTER TABLE ONLY public."DriverIdentification" DROP CONSTRAINT "DriverIdentification_EmployeeID_fkey";
       public          postgres    false    3243    222    220            �           2606    26696 '   LocationBase LocationBase_Director_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."LocationBase"
    ADD CONSTRAINT "LocationBase_Director_fkey" FOREIGN KEY ("Director") REFERENCES public."Employee"("EmployeeID");
 U   ALTER TABLE ONLY public."LocationBase" DROP CONSTRAINT "LocationBase_Director_fkey";
       public          postgres    false    224    3243    222            �           2606    26701    Package Package_CarID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Package"
    ADD CONSTRAINT "Package_CarID_fkey" FOREIGN KEY ("CarID") REFERENCES public."Car"("CarID");
 H   ALTER TABLE ONLY public."Package" DROP CONSTRAINT "Package_CarID_fkey";
       public          postgres    false    214    226    3225            �           2606    26706 "   Package Package_CargoCategory_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Package"
    ADD CONSTRAINT "Package_CargoCategory_fkey" FOREIGN KEY ("CargoCategory") REFERENCES public."CargoCategory"("CategoryID");
 P   ALTER TABLE ONLY public."Package" DROP CONSTRAINT "Package_CargoCategory_fkey";
       public          postgres    false    216    226    3227            �           2606    26711    Package Package_ClientID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Package"
    ADD CONSTRAINT "Package_ClientID_fkey" FOREIGN KEY ("ClientID") REFERENCES public."Client"("ClientID");
 K   ALTER TABLE ONLY public."Package" DROP CONSTRAINT "Package_ClientID_fkey";
       public          postgres    false    3233    226    218            �           2606    26716 $   Package Package_DeliveryAddress_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Package"
    ADD CONSTRAINT "Package_DeliveryAddress_fkey" FOREIGN KEY ("DeliveryAddress") REFERENCES public."PointReception"("PointID");
 R   ALTER TABLE ONLY public."Package" DROP CONSTRAINT "Package_DeliveryAddress_fkey";
       public          postgres    false    3249    228    226            �           2606    26721    Package Package_EmployeeID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Package"
    ADD CONSTRAINT "Package_EmployeeID_fkey" FOREIGN KEY ("EmployeeID") REFERENCES public."Employee"("EmployeeID");
 M   ALTER TABLE ONLY public."Package" DROP CONSTRAINT "Package_EmployeeID_fkey";
       public          postgres    false    222    3243    226            �           2606    26726 #   Package Package_SendingAddress_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Package"
    ADD CONSTRAINT "Package_SendingAddress_fkey" FOREIGN KEY ("SendingAddress") REFERENCES public."PointReception"("PointID");
 Q   ALTER TABLE ONLY public."Package" DROP CONSTRAINT "Package_SendingAddress_fkey";
       public          postgres    false    228    3249    226            �           2606    26731 +   PointReception PointReception_Director_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."PointReception"
    ADD CONSTRAINT "PointReception_Director_fkey" FOREIGN KEY ("Director") REFERENCES public."Employee"("EmployeeID");
 Y   ALTER TABLE ONLY public."PointReception" DROP CONSTRAINT "PointReception_Director_fkey";
       public          postgres    false    222    228    3243            �           2606    26736 .   PointReception PointReception_WarehouseID_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."PointReception"
    ADD CONSTRAINT "PointReception_WarehouseID_fkey" FOREIGN KEY ("WarehouseID") REFERENCES public."Warehouse"("WarehouseID");
 \   ALTER TABLE ONLY public."PointReception" DROP CONSTRAINT "PointReception_WarehouseID_fkey";
       public          postgres    false    228    3251    230            �           2606    26741 !   Warehouse Warehouse_Director_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Warehouse"
    ADD CONSTRAINT "Warehouse_Director_fkey" FOREIGN KEY ("Director") REFERENCES public."Employee"("EmployeeID");
 O   ALTER TABLE ONLY public."Warehouse" DROP CONSTRAINT "Warehouse_Director_fkey";
       public          postgres    false    230    222    3243            O   4   x�3�4426153��4�� " �������\�X���ih 0�b���� ���      Q   H   x�3�0�b�Ŧ��/��4�34@Q��ta߅M6\l�2⼰(�|a��]@��@�F�b;P���qqq ��6�      S   N   x�3�0�¦.�3.컰	�sa��vN#]C 2�4376153��4ര415��8S�s3s���s�b���� ҕ&�      U   +   x�3�44261�%�i`hd`h�k`�k`	d���\1z\\\ �b�      W   ~   x�3�4426I-/�0�¦.�3.컰	�sa��vN#]C 2�4�06153��4ര453��8/,��[�����;.캰�w���1gJ�Cznbf�^r~.�I@� l�����=\1z\\\ ϺB�      Y   T   x�3估��n��/6_츰�{/lP05�44⼰�¦[/6\�ra��}6]l*�p�_���p��b��NC�=... ��+`      [   d   x�3�4估�¾�.l��p����BF�F�z�FFƺ&�f
V`���34@�r����/l����֋M@1=�����1�!W� ��$�      ]   ;   x�3估��n��.컰���^ة`�i�i�e���{ao �r��qqq �v      _   \   x����	�0��)2�����+A�l����p��6�W��wpvT�{���Æ�bt��Af���S�ā��XQ9qD�T�FD^�;Q�     