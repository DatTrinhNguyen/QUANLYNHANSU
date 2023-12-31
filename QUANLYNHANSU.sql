PGDMP         *                {            QUANLYNHANSU    15.3    15.3 �                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16398    QUANLYNHANSU    DATABASE     �   CREATE DATABASE "QUANLYNHANSU" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "QUANLYNHANSU";
                postgres    false                       0    0    DATABASE "QUANLYNHANSU"    COMMENT     u   COMMENT ON DATABASE "QUANLYNHANSU" IS 'Phần mềm quản lý nhân sự đồ án môn Công nghệ phần mềm';
                   postgres    false    3587            �            1259    16404 	   tb.THAMSO    TABLE     7  CREATE TABLE public."tb.THAMSO" (
    "STT" smallint NOT NULL,
    "TUOINAMBD" smallint NOT NULL,
    "TUOINAMKT" smallint NOT NULL,
    "TUOINUBD" smallint NOT NULL,
    "TUOINUKT" smallint NOT NULL,
    "PHANTRAMBHYT" numeric(1,1) NOT NULL,
    "PHANTRAMBHXH" numeric(1,1) NOT NULL,
    "TRANGTHAI" bit(1)
);
    DROP TABLE public."tb.THAMSO";
       public         heap    postgres    false                       0    0    TABLE "tb.THAMSO"    COMMENT     M   COMMENT ON TABLE public."tb.THAMSO" IS 'Tham số chung của phần mềm';
          public          postgres    false    219            �            1259    16399    THAMSO_STT_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_STT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public."THAMSO_STT_seq";
       public          postgres    false    219                       0    0    THAMSO_STT_seq    SEQUENCE OWNED BY     J   ALTER SEQUENCE public."THAMSO_STT_seq" OWNED BY public."tb.THAMSO"."STT";
          public          postgres    false    214            �            1259    16400    THAMSO_TUOINAMBD_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINAMBD_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."THAMSO_TUOINAMBD_seq";
       public          postgres    false    219                       0    0    THAMSO_TUOINAMBD_seq    SEQUENCE OWNED BY     V   ALTER SEQUENCE public."THAMSO_TUOINAMBD_seq" OWNED BY public."tb.THAMSO"."TUOINAMBD";
          public          postgres    false    215            �            1259    16401    THAMSO_TUOINAMKT_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINAMKT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."THAMSO_TUOINAMKT_seq";
       public          postgres    false    219                       0    0    THAMSO_TUOINAMKT_seq    SEQUENCE OWNED BY     V   ALTER SEQUENCE public."THAMSO_TUOINAMKT_seq" OWNED BY public."tb.THAMSO"."TUOINAMKT";
          public          postgres    false    216            �            1259    16402    THAMSO_TUOINUBD_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINUBD_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."THAMSO_TUOINUBD_seq";
       public          postgres    false    219            	           0    0    THAMSO_TUOINUBD_seq    SEQUENCE OWNED BY     T   ALTER SEQUENCE public."THAMSO_TUOINUBD_seq" OWNED BY public."tb.THAMSO"."TUOINUBD";
          public          postgres    false    217            �            1259    16403    THAMSO_TUOINUKT_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINUKT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."THAMSO_TUOINUKT_seq";
       public          postgres    false    219            
           0    0    THAMSO_TUOINUKT_seq    SEQUENCE OWNED BY     T   ALTER SEQUENCE public."THAMSO_TUOINUKT_seq" OWNED BY public."tb.THAMSO"."TUOINUKT";
          public          postgres    false    218                       1259    16693    tb.BANGLUONG    TABLE       CREATE TABLE public."tb.BANGLUONG" (
    "ID" integer NOT NULL,
    "MAKYCONG" integer NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "NGAYCONG" numeric(2,1) NOT NULL,
    "NGAYNGHI" numeric(2,1) NOT NULL,
    "NGHIKHONGPHEP" numeric(2,1) NOT NULL,
    "CONGLE" numeric(3,1) NOT NULL,
    "CONGNHAT" numeric(3,1) NOT NULL,
    "TANGCA" numeric(3,1) NOT NULL,
    "THUCLANH" numeric(10,3) NOT NULL,
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date
);
 "   DROP TABLE public."tb.BANGLUONG";
       public         heap    postgres    false                       1259    16691    tb.BANGLUONG_ID_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BANGLUONG_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.BANGLUONG_ID_seq";
       public          postgres    false    264                       0    0    tb.BANGLUONG_ID_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.BANGLUONG_ID_seq" OWNED BY public."tb.BANGLUONG"."ID";
          public          postgres    false    262                       1259    16692    tb.BANGLUONG_MAKYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BANGLUONG_MAKYCONG_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.BANGLUONG_MAKYCONG_seq";
       public          postgres    false    264                       0    0    tb.BANGLUONG_MAKYCONG_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.BANGLUONG_MAKYCONG_seq" OWNED BY public."tb.BANGLUONG"."MAKYCONG";
          public          postgres    false    263            �            1259    16438 	   tb.CHUCVU    TABLE     �   CREATE TABLE public."tb.CHUCVU" (
    "IDCV" smallint NOT NULL,
    "TENCV" character varying(30) NOT NULL,
    "PCCV" numeric(10,3) NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.CHUCVU";
       public         heap    postgres    false                       0    0    TABLE "tb.CHUCVU"    COMMENT     E   COMMENT ON TABLE public."tb.CHUCVU" IS 'Chức vụ trong công ty';
          public          postgres    false    223            �            1259    16437    tb.CHUCVU_IDCV_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.CHUCVU_IDCV_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.CHUCVU_IDCV_seq";
       public          postgres    false    223                       0    0    tb.CHUCVU_IDCV_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.CHUCVU_IDCV_seq" OWNED BY public."tb.CHUCVU"."IDCV";
          public          postgres    false    222            �            1259    16651    tb.DIEUCHUYEN    TABLE     `  CREATE TABLE public."tb.DIEUCHUYEN" (
    "SOQD" character varying(8) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "NGAYLAP" date NOT NULL,
    "NGAYAPDUNG" date NOT NULL,
    "IDPB1" smallint NOT NULL,
    "IDCV1" smallint NOT NULL,
    "IDPB2" smallint NOT NULL,
    "IDCV2" smallint NOT NULL,
    "LYDO" character varying(100),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date,
    "TRANGTHAI" bit(1)
);
 #   DROP TABLE public."tb.DIEUCHUYEN";
       public         heap    postgres    false            �            1259    16648     tb.DIEUCHUYENTHANGCHUC_IDCV1_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq";
       public          postgres    false    255                       0    0     tb.DIEUCHUYENTHANGCHUC_IDCV1_seq    SEQUENCE OWNED BY     b   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq" OWNED BY public."tb.DIEUCHUYEN"."IDCV1";
          public          postgres    false    252            �            1259    16650     tb.DIEUCHUYENTHANGCHUC_IDCV2_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq";
       public          postgres    false    255                       0    0     tb.DIEUCHUYENTHANGCHUC_IDCV2_seq    SEQUENCE OWNED BY     b   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq" OWNED BY public."tb.DIEUCHUYEN"."IDCV2";
          public          postgres    false    254            �            1259    16647     tb.DIEUCHUYENTHANGCHUC_IDPB1_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq";
       public          postgres    false    255                       0    0     tb.DIEUCHUYENTHANGCHUC_IDPB1_seq    SEQUENCE OWNED BY     b   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq" OWNED BY public."tb.DIEUCHUYEN"."IDPB1";
          public          postgres    false    251            �            1259    16649     tb.DIEUCHUYENTHANGCHUC_IDPB2_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq";
       public          postgres    false    255                       0    0     tb.DIEUCHUYENTHANGCHUC_IDPB2_seq    SEQUENCE OWNED BY     b   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq" OWNED BY public."tb.DIEUCHUYEN"."IDPB2";
          public          postgres    false    253            �            1259    16548    tb.HOPDONGLAODONG    TABLE       CREATE TABLE public."tb.HOPDONGLAODONG" (
    "HD" character varying(8) NOT NULL,
    "IDNV" character varying(8) NOT NULL,
    "NGAYBATDAU" date NOT NULL,
    "NGAYKETTHUC" date NOT NULL,
    "THOIHAN" smallint NOT NULL,
    "NGAYKY" date NOT NULL,
    "LUONG" numeric(10,3) NOT NULL,
    "HESO" numeric(1,3) NOT NULL,
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date,
    "TRANGTHAI" bit(1)
);
 '   DROP TABLE public."tb.HOPDONGLAODONG";
       public         heap    postgres    false                       0    0    TABLE "tb.HOPDONGLAODONG"    COMMENT     X   COMMENT ON TABLE public."tb.HOPDONGLAODONG" IS 'hợp đồng lao động nhân viên';
          public          postgres    false    243            �            1259    16547    tb.HOPDONGLAODONG_THOIHAN_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.HOPDONGLAODONG_THOIHAN_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public."tb.HOPDONGLAODONG_THOIHAN_seq";
       public          postgres    false    243                       0    0    tb.HOPDONGLAODONG_THOIHAN_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public."tb.HOPDONGLAODONG_THOIHAN_seq" OWNED BY public."tb.HOPDONGLAODONG"."THOIHAN";
          public          postgres    false    242                        1259    16665    tb.KHENTHUONG    TABLE     �  CREATE TABLE public."tb.KHENTHUONG" (
    "MAKT" character varying(8) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "NGAYLAP" date NOT NULL,
    "SOTIEN" numeric(10,3) NOT NULL,
    "LYDO" character varying(100),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date,
    "TRANGTHAI" bit(1)
);
 #   DROP TABLE public."tb.KHENTHUONG";
       public         heap    postgres    false                       0    0    TABLE "tb.KHENTHUONG"    COMMENT     U   COMMENT ON TABLE public."tb.KHENTHUONG" IS 'Khen thưởng kỷ luật nhân viên';
          public          postgres    false    256                       1259    16680 	   tb.KYCONG    TABLE     �  CREATE TABLE public."tb.KYCONG" (
    "MAKYCONG" integer NOT NULL,
    "THANG" smallint NOT NULL,
    "NAM" smallint NOT NULL,
    "NGAYTINHCONG" date NOT NULL,
    "NGAYCONGTHANG" smallint NOT NULL,
    "TRANGTHAI" bit(1),
    "KHÓA" bit(1),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
    DROP TABLE public."tb.KYCONG";
       public         heap    postgres    false                       0    0    TABLE "tb.KYCONG"    COMMENT     j   COMMENT ON TABLE public."tb.KYCONG" IS 'Kỳ công của nhân viên. Mỗi tháng là một kỳ công';
          public          postgres    false    261                       1259    16676    tb.KYCONG_MAKYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_MAKYCONG_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."tb.KYCONG_MAKYCONG_seq";
       public          postgres    false    261                       0    0    tb.KYCONG_MAKYCONG_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."tb.KYCONG_MAKYCONG_seq" OWNED BY public."tb.KYCONG"."MAKYCONG";
          public          postgres    false    257                       1259    16678    tb.KYCONG_NAM_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_NAM_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."tb.KYCONG_NAM_seq";
       public          postgres    false    261                       0    0    tb.KYCONG_NAM_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public."tb.KYCONG_NAM_seq" OWNED BY public."tb.KYCONG"."NAM";
          public          postgres    false    259                       1259    16679    tb.KYCONG_NGAYCONGTHANG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_NGAYCONGTHANG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public."tb.KYCONG_NGAYCONGTHANG_seq";
       public          postgres    false    261                       0    0    tb.KYCONG_NGAYCONGTHANG_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public."tb.KYCONG_NGAYCONGTHANG_seq" OWNED BY public."tb.KYCONG"."NGAYCONGTHANG";
          public          postgres    false    260                       1259    16677    tb.KYCONG_THANG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_THANG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.KYCONG_THANG_seq";
       public          postgres    false    261                       0    0    tb.KYCONG_THANG_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.KYCONG_THANG_seq" OWNED BY public."tb.KYCONG"."THANG";
          public          postgres    false    258            
           1259    24618 	   tb.KYLUAT    TABLE     6  CREATE TABLE public."tb.KYLUAT" (
    "MAKL" character varying(8) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "NGAYLAP" date NOT NULL,
    "SOTIEN" numeric(10,3) NOT NULL,
    "GHICHU" character varying(100) NOT NULL,
    "TRANGTHAI" bit(1) NOT NULL
);
    DROP TABLE public."tb.KYLUAT";
       public         heap    postgres    false            �            1259    16445 	   tb.LOAICA    TABLE     �   CREATE TABLE public."tb.LOAICA" (
    "IDLC" smallint NOT NULL,
    "TENLC" character varying(30) NOT NULL,
    "HESO" numeric(1,3) NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.LOAICA";
       public         heap    postgres    false                       0    0    TABLE "tb.LOAICA"    COMMENT     A   COMMENT ON TABLE public."tb.LOAICA" IS 'Các ca trong công ty';
          public          postgres    false    225            �            1259    16444    tb.LOAICA_IDLC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.LOAICA_IDLC_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.LOAICA_IDLC_seq";
       public          postgres    false    225                       0    0    tb.LOAICA_IDLC_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.LOAICA_IDLC_seq" OWNED BY public."tb.LOAICA"."IDLC";
          public          postgres    false    224            �            1259    16452    tb.LOAICONG    TABLE     �   CREATE TABLE public."tb.LOAICONG" (
    "IDLCONG" smallint NOT NULL,
    "TENLCONG" character varying(30) NOT NULL,
    "HESO" numeric(1,3) NOT NULL,
    "TRANGTHAI" boolean
);
 !   DROP TABLE public."tb.LOAICONG";
       public         heap    postgres    false                       0    0    TABLE "tb.LOAICONG"    COMMENT     H   COMMENT ON TABLE public."tb.LOAICONG" IS 'loại công trong công ty';
          public          postgres    false    227            �            1259    16451    tb.LOAICONG_IDLCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.LOAICONG_IDLCONG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."tb.LOAICONG_IDLCONG_seq";
       public          postgres    false    227                       0    0    tb.LOAICONG_IDLCONG_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public."tb.LOAICONG_IDLCONG_seq" OWNED BY public."tb.LOAICONG"."IDLCONG";
          public          postgres    false    226            �            1259    16504    tb.NHANVIEN    TABLE     �  CREATE TABLE public."tb.NHANVIEN" (
    "IDNV" character varying(10) NOT NULL,
    "HODEM" character varying(40) NOT NULL,
    "TEN" character varying(20) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "GIOITINH" bit(1) NOT NULL,
    "NGAYSINH" date NOT NULL,
    "CMND" character varying(15) NOT NULL,
    "HINHANH" bytea NOT NULL,
    "SDT" character varying(14) NOT NULL,
    "DIACHI" character varying(100) NOT NULL,
    "IDPB" smallint NOT NULL,
    "IDCV" smallint NOT NULL,
    "LUONG" numeric(10,3) NOT NULL,
    "NGAYGIANHAP" date NOT NULL,
    "TRANGTHAI" bit(1) NOT NULL,
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date,
    "DANTOC" character varying(30) NOT NULL,
    "TONGIAO" character varying(30) NOT NULL,
    "TRINHDO" character varying(30) NOT NULL
);
 !   DROP TABLE public."tb.NHANVIEN";
       public         heap    postgres    false                       0    0    TABLE "tb.NHANVIEN"    COMMENT     G   COMMENT ON TABLE public."tb.NHANVIEN" IS 'nhân viên trong công ty';
          public          postgres    false    240            	           1259    24601    tb.NHANVIENBAOHIEMXAHOI    TABLE     7  CREATE TABLE public."tb.NHANVIENBAOHIEMXAHOI" (
    "BHXH" character varying(15) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "SOTIEN" numeric(10,3) NOT NULL,
    "NGAYDONG" date NOT NULL,
    "THOIHAN" date NOT NULL,
    "TRANGTHAI" bit(1) NOT NULL,
    "GHICHU" character varying(100) NOT NULL
);
 -   DROP TABLE public."tb.NHANVIENBAOHIEMXAHOI";
       public         heap    postgres    false            �            1259    16590    tb.NHANVIENBAOHIEMYTE    TABLE     �  CREATE TABLE public."tb.NHANVIENBAOHIEMYTE" (
    "BHYT" character varying(17) NOT NULL,
    "SOTIEN" numeric(9,3) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "NGAYDONG" date NOT NULL,
    "NGAYKETTHUC" date,
    "TRANGTHAI" bit(1),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date,
    "GHICHU" character varying(100) NOT NULL
);
 +   DROP TABLE public."tb.NHANVIENBAOHIEMYTE";
       public         heap    postgres    false            �            1259    16589    tb.NHANVIENBAOHIEM_BH_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENBAOHIEM_BH_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.NHANVIENBAOHIEM_BH_seq";
       public          postgres    false    246                        0    0    tb.NHANVIENBAOHIEM_BH_seq    SEQUENCE OWNED BY     d   ALTER SEQUENCE public."tb.NHANVIENBAOHIEM_BH_seq" OWNED BY public."tb.NHANVIENBAOHIEMYTE"."SOTIEN";
          public          postgres    false    245            �            1259    16483    tb.NHANVIENPHUCAP    TABLE        CREATE TABLE public."tb.NHANVIENPHUCAP" (
    "ID" integer NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "IDPC" smallint NOT NULL,
    "NGAY" smallint NOT NULL,
    "THANG" smallint NOT NULL,
    "NAM" smallint NOT NULL,
    "KYCONG" integer NOT NULL,
    "NOIDUNG" character varying(150) NOT NULL,
    "SOTIEN" numeric(10,3) NOT NULL,
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
 '   DROP TABLE public."tb.NHANVIENPHUCAP";
       public         heap    postgres    false            !           0    0    TABLE "tb.NHANVIENPHUCAP"    COMMENT     q   COMMENT ON TABLE public."tb.NHANVIENPHUCAP" IS 'các nhân viên nhận được phụ cấp của nhân viên';
          public          postgres    false    237            �            1259    16478    tb.NHANVIENPHUCAP_IDPC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_IDPC_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public."tb.NHANVIENPHUCAP_IDPC_seq";
       public          postgres    false    237            "           0    0    tb.NHANVIENPHUCAP_IDPC_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_IDPC_seq" OWNED BY public."tb.NHANVIENPHUCAP"."IDPC";
          public          postgres    false    232            �            1259    16477    tb.NHANVIENPHUCAP_ID_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."tb.NHANVIENPHUCAP_ID_seq";
       public          postgres    false    237            #           0    0    tb.NHANVIENPHUCAP_ID_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_ID_seq" OWNED BY public."tb.NHANVIENPHUCAP"."ID";
          public          postgres    false    231            �            1259    16482    tb.NHANVIENPHUCAP_KYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_KYCONG_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public."tb.NHANVIENPHUCAP_KYCONG_seq";
       public          postgres    false    237            $           0    0    tb.NHANVIENPHUCAP_KYCONG_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_KYCONG_seq" OWNED BY public."tb.NHANVIENPHUCAP"."KYCONG";
          public          postgres    false    236            �            1259    16481    tb.NHANVIENPHUCAP_NAM_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_NAM_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.NHANVIENPHUCAP_NAM_seq";
       public          postgres    false    237            %           0    0    tb.NHANVIENPHUCAP_NAM_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_NAM_seq" OWNED BY public."tb.NHANVIENPHUCAP"."NAM";
          public          postgres    false    235            �            1259    16479    tb.NHANVIENPHUCAP_NGAY_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_NGAY_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public."tb.NHANVIENPHUCAP_NGAY_seq";
       public          postgres    false    237            &           0    0    tb.NHANVIENPHUCAP_NGAY_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_NGAY_seq" OWNED BY public."tb.NHANVIENPHUCAP"."NGAY";
          public          postgres    false    233            �            1259    16480    tb.NHANVIENPHUCAP_THANG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_THANG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public."tb.NHANVIENPHUCAP_THANG_seq";
       public          postgres    false    237            '           0    0    tb.NHANVIENPHUCAP_THANG_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_THANG_seq" OWNED BY public."tb.NHANVIENPHUCAP"."THANG";
          public          postgres    false    234            �            1259    16503    tb.NHANVIEN_IDCV_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIEN_IDCV_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.NHANVIEN_IDCV_seq";
       public          postgres    false    240            (           0    0    tb.NHANVIEN_IDCV_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.NHANVIEN_IDCV_seq" OWNED BY public."tb.NHANVIEN"."IDCV";
          public          postgres    false    239            �            1259    16502    tb.NHANVIEN_IDPB_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIEN_IDPB_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.NHANVIEN_IDPB_seq";
       public          postgres    false    240            )           0    0    tb.NHANVIEN_IDPB_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.NHANVIEN_IDPB_seq" OWNED BY public."tb.NHANVIEN"."IDPB";
          public          postgres    false    238            �            1259    16431    tb.PHONGBAN    TABLE     �   CREATE TABLE public."tb.PHONGBAN" (
    "IDPB" smallint NOT NULL,
    "TENPB" character varying(30) NOT NULL,
    "PCPB" numeric(10,3) NOT NULL,
    "TRANGTHAI" boolean
);
 !   DROP TABLE public."tb.PHONGBAN";
       public         heap    postgres    false            *           0    0    TABLE "tb.PHONGBAN"    COMMENT     F   COMMENT ON TABLE public."tb.PHONGBAN" IS 'Phòng ban trong công ty';
          public          postgres    false    221            �            1259    16430    tb.PHONGBAN_IDPB_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.PHONGBAN_IDPB_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.PHONGBAN_IDPB_seq";
       public          postgres    false    221            +           0    0    tb.PHONGBAN_IDPB_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.PHONGBAN_IDPB_seq" OWNED BY public."tb.PHONGBAN"."IDPB";
          public          postgres    false    220            �            1259    16466 	   tb.PHUCAP    TABLE     �   CREATE TABLE public."tb.PHUCAP" (
    "IDPC" smallint NOT NULL,
    "TENPC" character varying(30) NOT NULL,
    "SOTIEN" numeric(10,3) NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.PHUCAP";
       public         heap    postgres    false            ,           0    0    TABLE "tb.PHUCAP"    COMMENT     E   COMMENT ON TABLE public."tb.PHUCAP" IS 'Phụ cấp trong công ty';
          public          postgres    false    229            �            1259    16465    tb.PHUCAP_IDPC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.PHUCAP_IDPC_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.PHUCAP_IDPC_seq";
       public          postgres    false    229            -           0    0    tb.PHUCAP_IDPC_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.PHUCAP_IDPC_seq" OWNED BY public."tb.PHUCAP"."IDPC";
          public          postgres    false    228            �            1259    16472    tb.TAIKHOAN    TABLE     �  CREATE TABLE public."tb.TAIKHOAN" (
    "TAIKHOAN" character varying(15) NOT NULL,
    "MATKHAU" character varying(25) NOT NULL,
    "IDNV" character(10) NOT NULL,
    "EMAIL" character varying(70) NOT NULL,
    "TRANGTHAI" boolean NOT NULL,
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATE_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
 !   DROP TABLE public."tb.TAIKHOAN";
       public         heap    postgres    false            .           0    0    TABLE "tb.TAIKHOAN"    COMMENT     r   COMMENT ON TABLE public."tb.TAIKHOAN" IS 'Tài khoản trong công ty và tài khoản dùng trong phần mềm';
          public          postgres    false    230            �            1259    16542    tb.TANGLUONG    TABLE     �  CREATE TABLE public."tb.TANGLUONG" (
    "MATL" character varying(8) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "LUONGCU" numeric(10,3) NOT NULL,
    "LUONGMOI" numeric NOT NULL,
    "NGAYLENLUONG" date NOT NULL,
    "NGAYLAP" date,
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
 "   DROP TABLE public."tb.TANGLUONG";
       public         heap    postgres    false            /           0    0    TABLE "tb.TANGLUONG"    COMMENT     G   COMMENT ON TABLE public."tb.TANGLUONG" IS 'Nhân viên tăng lương';
          public          postgres    false    241                       1259    24631    tb.THANGCHUC    TABLE     ]  CREATE TABLE public."tb.THANGCHUC" (
    "SOQD" character varying(8) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "NGAYLAP" date NOT NULL,
    "NGAYAPDUNG" date NOT NULL,
    "IDPB" smallint NOT NULL,
    "IDCV1" smallint NOT NULL,
    "LYDO" character varying(100),
    "TRANGTHAI" bit(1)
);
 "   DROP TABLE public."tb.THANGCHUC";
       public         heap    postgres    false                       1259    24630    tb.THANGCHUC_IDCV1_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.THANGCHUC_IDCV1_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."tb.THANGCHUC_IDCV1_seq";
       public          postgres    false    269            0           0    0    tb.THANGCHUC_IDCV1_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."tb.THANGCHUC_IDCV1_seq" OWNED BY public."tb.THANGCHUC"."IDCV1";
          public          postgres    false    268                       1259    24629    tb.THANGCHUC_IDPB_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.THANGCHUC_IDPB_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public."tb.THANGCHUC_IDPB_seq";
       public          postgres    false    269            1           0    0    tb.THANGCHUC_IDPB_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public."tb.THANGCHUC_IDPB_seq" OWNED BY public."tb.THANGCHUC"."IDPB";
          public          postgres    false    267            �            1259    16564    tb.THOIVIEC    TABLE     �  CREATE TABLE public."tb.THOIVIEC" (
    "HDTV" character varying(8) NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "NGAYNOPDON" date NOT NULL,
    "NGAYNGHI" date NOT NULL,
    "LYDO" character varying(200),
    "GHICHU" character varying(200),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date,
    "TRANGTHAI" bit(1)
);
 !   DROP TABLE public."tb.THOIVIEC";
       public         heap    postgres    false            2           0    0    TABLE "tb.THOIVIEC"    COMMENT     E   COMMENT ON TABLE public."tb.THOIVIEC" IS 'nhân viên thôi việc';
          public          postgres    false    244            �            1259    16634    tb.UNGLUONG    TABLE     �  CREATE TABLE public."tb.UNGLUONG" (
    "STT" integer NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "NGAYTAO" smallint NOT NULL,
    "MAKYCONG" smallint NOT NULL,
    "SOTIEN" numeric(11,3) NOT NULL,
    "LYDO" character varying(100),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date,
    "TRANGTHAI" bit(1)
);
 !   DROP TABLE public."tb.UNGLUONG";
       public         heap    postgres    false            3           0    0    TABLE "tb.UNGLUONG"    COMMENT     F   COMMENT ON TABLE public."tb.UNGLUONG" IS 'Nhân viên ứng lương';
          public          postgres    false    250            �            1259    16633    tb.UNGLUONG_MAKYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.UNGLUONG_MAKYCONG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."tb.UNGLUONG_MAKYCONG_seq";
       public          postgres    false    250            4           0    0    tb.UNGLUONG_MAKYCONG_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."tb.UNGLUONG_MAKYCONG_seq" OWNED BY public."tb.UNGLUONG"."MAKYCONG";
          public          postgres    false    249            �            1259    16632    tb.UNGLUONG_NGAYTAO_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.UNGLUONG_NGAYTAO_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."tb.UNGLUONG_NGAYTAO_seq";
       public          postgres    false    250            5           0    0    tb.UNGLUONG_NGAYTAO_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public."tb.UNGLUONG_NGAYTAO_seq" OWNED BY public."tb.UNGLUONG"."NGAYTAO";
          public          postgres    false    248            �            1259    16631    tb.UNGLUONG_STT_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.UNGLUONG_STT_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.UNGLUONG_STT_seq";
       public          postgres    false    250            6           0    0    tb.UNGLUONG_STT_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.UNGLUONG_STT_seq" OWNED BY public."tb.UNGLUONG"."STT";
          public          postgres    false    247            �           2604    16696    tb.BANGLUONG ID    DEFAULT     x   ALTER TABLE ONLY public."tb.BANGLUONG" ALTER COLUMN "ID" SET DEFAULT nextval('public."tb.BANGLUONG_ID_seq"'::regclass);
 B   ALTER TABLE public."tb.BANGLUONG" ALTER COLUMN "ID" DROP DEFAULT;
       public          postgres    false    264    262    264            �           2604    16697    tb.BANGLUONG MAKYCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.BANGLUONG" ALTER COLUMN "MAKYCONG" SET DEFAULT nextval('public."tb.BANGLUONG_MAKYCONG_seq"'::regclass);
 H   ALTER TABLE public."tb.BANGLUONG" ALTER COLUMN "MAKYCONG" DROP DEFAULT;
       public          postgres    false    264    263    264            �           2604    16441    tb.CHUCVU IDCV    DEFAULT     v   ALTER TABLE ONLY public."tb.CHUCVU" ALTER COLUMN "IDCV" SET DEFAULT nextval('public."tb.CHUCVU_IDCV_seq"'::regclass);
 A   ALTER TABLE public."tb.CHUCVU" ALTER COLUMN "IDCV" DROP DEFAULT;
       public          postgres    false    223    222    223            �           2604    16654    tb.DIEUCHUYEN IDPB1    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYEN" ALTER COLUMN "IDPB1" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq"'::regclass);
 F   ALTER TABLE public."tb.DIEUCHUYEN" ALTER COLUMN "IDPB1" DROP DEFAULT;
       public          postgres    false    255    251    255            �           2604    16655    tb.DIEUCHUYEN IDCV1    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYEN" ALTER COLUMN "IDCV1" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq"'::regclass);
 F   ALTER TABLE public."tb.DIEUCHUYEN" ALTER COLUMN "IDCV1" DROP DEFAULT;
       public          postgres    false    252    255    255            �           2604    16656    tb.DIEUCHUYEN IDPB2    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYEN" ALTER COLUMN "IDPB2" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq"'::regclass);
 F   ALTER TABLE public."tb.DIEUCHUYEN" ALTER COLUMN "IDPB2" DROP DEFAULT;
       public          postgres    false    253    255    255            �           2604    16657    tb.DIEUCHUYEN IDCV2    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYEN" ALTER COLUMN "IDCV2" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq"'::regclass);
 F   ALTER TABLE public."tb.DIEUCHUYEN" ALTER COLUMN "IDCV2" DROP DEFAULT;
       public          postgres    false    254    255    255            �           2604    16551    tb.HOPDONGLAODONG THOIHAN    DEFAULT     �   ALTER TABLE ONLY public."tb.HOPDONGLAODONG" ALTER COLUMN "THOIHAN" SET DEFAULT nextval('public."tb.HOPDONGLAODONG_THOIHAN_seq"'::regclass);
 L   ALTER TABLE public."tb.HOPDONGLAODONG" ALTER COLUMN "THOIHAN" DROP DEFAULT;
       public          postgres    false    243    242    243            �           2604    16684    tb.KYCONG MAKYCONG    DEFAULT     ~   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "MAKYCONG" SET DEFAULT nextval('public."tb.KYCONG_MAKYCONG_seq"'::regclass);
 E   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "MAKYCONG" DROP DEFAULT;
       public          postgres    false    261    257    261            �           2604    16685    tb.KYCONG THANG    DEFAULT     x   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "THANG" SET DEFAULT nextval('public."tb.KYCONG_THANG_seq"'::regclass);
 B   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "THANG" DROP DEFAULT;
       public          postgres    false    258    261    261            �           2604    16686    tb.KYCONG NAM    DEFAULT     t   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "NAM" SET DEFAULT nextval('public."tb.KYCONG_NAM_seq"'::regclass);
 @   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "NAM" DROP DEFAULT;
       public          postgres    false    259    261    261            �           2604    16687    tb.KYCONG NGAYCONGTHANG    DEFAULT     �   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "NGAYCONGTHANG" SET DEFAULT nextval('public."tb.KYCONG_NGAYCONGTHANG_seq"'::regclass);
 J   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "NGAYCONGTHANG" DROP DEFAULT;
       public          postgres    false    260    261    261            �           2604    16448    tb.LOAICA IDLC    DEFAULT     v   ALTER TABLE ONLY public."tb.LOAICA" ALTER COLUMN "IDLC" SET DEFAULT nextval('public."tb.LOAICA_IDLC_seq"'::regclass);
 A   ALTER TABLE public."tb.LOAICA" ALTER COLUMN "IDLC" DROP DEFAULT;
       public          postgres    false    225    224    225            �           2604    16455    tb.LOAICONG IDLCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.LOAICONG" ALTER COLUMN "IDLCONG" SET DEFAULT nextval('public."tb.LOAICONG_IDLCONG_seq"'::regclass);
 F   ALTER TABLE public."tb.LOAICONG" ALTER COLUMN "IDLCONG" DROP DEFAULT;
       public          postgres    false    227    226    227            �           2604    16510    tb.NHANVIEN IDPB    DEFAULT     z   ALTER TABLE ONLY public."tb.NHANVIEN" ALTER COLUMN "IDPB" SET DEFAULT nextval('public."tb.NHANVIEN_IDPB_seq"'::regclass);
 C   ALTER TABLE public."tb.NHANVIEN" ALTER COLUMN "IDPB" DROP DEFAULT;
       public          postgres    false    238    240    240            �           2604    16511    tb.NHANVIEN IDCV    DEFAULT     z   ALTER TABLE ONLY public."tb.NHANVIEN" ALTER COLUMN "IDCV" SET DEFAULT nextval('public."tb.NHANVIEN_IDCV_seq"'::regclass);
 C   ALTER TABLE public."tb.NHANVIEN" ALTER COLUMN "IDCV" DROP DEFAULT;
       public          postgres    false    239    240    240            �           2604    16486    tb.NHANVIENPHUCAP ID    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "ID" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_ID_seq"'::regclass);
 G   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "ID" DROP DEFAULT;
       public          postgres    false    231    237    237            �           2604    16487    tb.NHANVIENPHUCAP IDPC    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "IDPC" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_IDPC_seq"'::regclass);
 I   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "IDPC" DROP DEFAULT;
       public          postgres    false    237    232    237            �           2604    16488    tb.NHANVIENPHUCAP NGAY    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "NGAY" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_NGAY_seq"'::regclass);
 I   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "NGAY" DROP DEFAULT;
       public          postgres    false    237    233    237            �           2604    16489    tb.NHANVIENPHUCAP THANG    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "THANG" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_THANG_seq"'::regclass);
 J   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "THANG" DROP DEFAULT;
       public          postgres    false    237    234    237            �           2604    16490    tb.NHANVIENPHUCAP NAM    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "NAM" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_NAM_seq"'::regclass);
 H   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "NAM" DROP DEFAULT;
       public          postgres    false    235    237    237            �           2604    16491    tb.NHANVIENPHUCAP KYCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "KYCONG" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_KYCONG_seq"'::regclass);
 K   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "KYCONG" DROP DEFAULT;
       public          postgres    false    237    236    237            �           2604    16434    tb.PHONGBAN IDPB    DEFAULT     z   ALTER TABLE ONLY public."tb.PHONGBAN" ALTER COLUMN "IDPB" SET DEFAULT nextval('public."tb.PHONGBAN_IDPB_seq"'::regclass);
 C   ALTER TABLE public."tb.PHONGBAN" ALTER COLUMN "IDPB" DROP DEFAULT;
       public          postgres    false    220    221    221            �           2604    16469    tb.PHUCAP IDPC    DEFAULT     v   ALTER TABLE ONLY public."tb.PHUCAP" ALTER COLUMN "IDPC" SET DEFAULT nextval('public."tb.PHUCAP_IDPC_seq"'::regclass);
 A   ALTER TABLE public."tb.PHUCAP" ALTER COLUMN "IDPC" DROP DEFAULT;
       public          postgres    false    228    229    229            �           2604    16407    tb.THAMSO STT    DEFAULT     q   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "STT" SET DEFAULT nextval('public."THAMSO_STT_seq"'::regclass);
 @   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "STT" DROP DEFAULT;
       public          postgres    false    219    214    219            �           2604    16408    tb.THAMSO TUOINAMBD    DEFAULT     }   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINAMBD" SET DEFAULT nextval('public."THAMSO_TUOINAMBD_seq"'::regclass);
 F   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINAMBD" DROP DEFAULT;
       public          postgres    false    219    215    219            �           2604    16409    tb.THAMSO TUOINAMKT    DEFAULT     }   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINAMKT" SET DEFAULT nextval('public."THAMSO_TUOINAMKT_seq"'::regclass);
 F   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINAMKT" DROP DEFAULT;
       public          postgres    false    219    216    219            �           2604    16410    tb.THAMSO TUOINUBD    DEFAULT     {   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINUBD" SET DEFAULT nextval('public."THAMSO_TUOINUBD_seq"'::regclass);
 E   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINUBD" DROP DEFAULT;
       public          postgres    false    217    219    219            �           2604    16411    tb.THAMSO TUOINUKT    DEFAULT     {   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINUKT" SET DEFAULT nextval('public."THAMSO_TUOINUKT_seq"'::regclass);
 E   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINUKT" DROP DEFAULT;
       public          postgres    false    218    219    219            �           2604    24634    tb.THANGCHUC IDPB    DEFAULT     |   ALTER TABLE ONLY public."tb.THANGCHUC" ALTER COLUMN "IDPB" SET DEFAULT nextval('public."tb.THANGCHUC_IDPB_seq"'::regclass);
 D   ALTER TABLE public."tb.THANGCHUC" ALTER COLUMN "IDPB" DROP DEFAULT;
       public          postgres    false    269    267    269            �           2604    24635    tb.THANGCHUC IDCV1    DEFAULT     ~   ALTER TABLE ONLY public."tb.THANGCHUC" ALTER COLUMN "IDCV1" SET DEFAULT nextval('public."tb.THANGCHUC_IDCV1_seq"'::regclass);
 E   ALTER TABLE public."tb.THANGCHUC" ALTER COLUMN "IDCV1" DROP DEFAULT;
       public          postgres    false    268    269    269            �           2604    16637    tb.UNGLUONG STT    DEFAULT     x   ALTER TABLE ONLY public."tb.UNGLUONG" ALTER COLUMN "STT" SET DEFAULT nextval('public."tb.UNGLUONG_STT_seq"'::regclass);
 B   ALTER TABLE public."tb.UNGLUONG" ALTER COLUMN "STT" DROP DEFAULT;
       public          postgres    false    250    247    250            �           2604    16638    tb.UNGLUONG NGAYTAO    DEFAULT     �   ALTER TABLE ONLY public."tb.UNGLUONG" ALTER COLUMN "NGAYTAO" SET DEFAULT nextval('public."tb.UNGLUONG_NGAYTAO_seq"'::regclass);
 F   ALTER TABLE public."tb.UNGLUONG" ALTER COLUMN "NGAYTAO" DROP DEFAULT;
       public          postgres    false    250    248    250            �           2604    16639    tb.UNGLUONG MAKYCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.UNGLUONG" ALTER COLUMN "MAKYCONG" SET DEFAULT nextval('public."tb.UNGLUONG_MAKYCONG_seq"'::regclass);
 G   ALTER TABLE public."tb.UNGLUONG" ALTER COLUMN "MAKYCONG" DROP DEFAULT;
       public          postgres    false    250    249    250            �          0    16693    tb.BANGLUONG 
   TABLE DATA           �   COPY public."tb.BANGLUONG" ("ID", "MAKYCONG", "IDNV", "HOTEN", "NGAYCONG", "NGAYNGHI", "NGHIKHONGPHEP", "CONGLE", "CONGNHAT", "TANGCA", "THUCLANH", "CREATED_BY", "CREATED_DATE") FROM stdin;
    public          postgres    false    264   �7      �          0    16438 	   tb.CHUCVU 
   TABLE DATA           K   COPY public."tb.CHUCVU" ("IDCV", "TENCV", "PCCV", "TRANGTHAI") FROM stdin;
    public          postgres    false    223   8      �          0    16651    tb.DIEUCHUYEN 
   TABLE DATA           �   COPY public."tb.DIEUCHUYEN" ("SOQD", "IDNV", "HOTEN", "NGAYLAP", "NGAYAPDUNG", "IDPB1", "IDCV1", "IDPB2", "IDCV2", "LYDO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE", "TRANGTHAI") FROM stdin;
    public          postgres    false    255   18      �          0    16548    tb.HOPDONGLAODONG 
   TABLE DATA           �   COPY public."tb.HOPDONGLAODONG" ("HD", "IDNV", "NGAYBATDAU", "NGAYKETTHUC", "THOIHAN", "NGAYKY", "LUONG", "HESO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE", "TRANGTHAI") FROM stdin;
    public          postgres    false    243   N8      �          0    16665    tb.KHENTHUONG 
   TABLE DATA           �   COPY public."tb.KHENTHUONG" ("MAKT", "IDNV", "HOTEN", "NGAYLAP", "SOTIEN", "LYDO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE", "TRANGTHAI") FROM stdin;
    public          postgres    false    256   k8      �          0    16680 	   tb.KYCONG 
   TABLE DATA           �   COPY public."tb.KYCONG" ("MAKYCONG", "THANG", "NAM", "NGAYTINHCONG", "NGAYCONGTHANG", "TRANGTHAI", "KHÓA", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    261   �8      �          0    24618 	   tb.KYLUAT 
   TABLE DATA           j   COPY public."tb.KYLUAT" ("MAKL", "IDNV", "HOTEN", "NGAYLAP", "SOTIEN", "GHICHU", "TRANGTHAI") FROM stdin;
    public          postgres    false    266   �8      �          0    16445 	   tb.LOAICA 
   TABLE DATA           K   COPY public."tb.LOAICA" ("IDLC", "TENLC", "HESO", "TRANGTHAI") FROM stdin;
    public          postgres    false    225   �8      �          0    16452    tb.LOAICONG 
   TABLE DATA           S   COPY public."tb.LOAICONG" ("IDLCONG", "TENLCONG", "HESO", "TRANGTHAI") FROM stdin;
    public          postgres    false    227   �8      �          0    16504    tb.NHANVIEN 
   TABLE DATA           3  COPY public."tb.NHANVIEN" ("IDNV", "HODEM", "TEN", "HOTEN", "GIOITINH", "NGAYSINH", "CMND", "HINHANH", "SDT", "DIACHI", "IDPB", "IDCV", "LUONG", "NGAYGIANHAP", "TRANGTHAI", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE", "DANTOC", "TONGIAO", "TRINHDO") FROM stdin;
    public          postgres    false    240   �8      �          0    24601    tb.NHANVIENBAOHIEMXAHOI 
   TABLE DATA           {   COPY public."tb.NHANVIENBAOHIEMXAHOI" ("BHXH", "IDNV", "SOTIEN", "NGAYDONG", "THOIHAN", "TRANGTHAI", "GHICHU") FROM stdin;
    public          postgres    false    265   9      �          0    16590    tb.NHANVIENBAOHIEMYTE 
   TABLE DATA           �   COPY public."tb.NHANVIENBAOHIEMYTE" ("BHYT", "SOTIEN", "IDNV", "NGAYDONG", "NGAYKETTHUC", "TRANGTHAI", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE", "GHICHU") FROM stdin;
    public          postgres    false    246   69      �          0    16483    tb.NHANVIENPHUCAP 
   TABLE DATA           �   COPY public."tb.NHANVIENPHUCAP" ("ID", "IDNV", "IDPC", "NGAY", "THANG", "NAM", "KYCONG", "NOIDUNG", "SOTIEN", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    237   S9      �          0    16431    tb.PHONGBAN 
   TABLE DATA           M   COPY public."tb.PHONGBAN" ("IDPB", "TENPB", "PCPB", "TRANGTHAI") FROM stdin;
    public          postgres    false    221   p9      �          0    16466 	   tb.PHUCAP 
   TABLE DATA           M   COPY public."tb.PHUCAP" ("IDPC", "TENPC", "SOTIEN", "TRANGTHAI") FROM stdin;
    public          postgres    false    229   �9      �          0    16472    tb.TAIKHOAN 
   TABLE DATA           �   COPY public."tb.TAIKHOAN" ("TAIKHOAN", "MATKHAU", "IDNV", "EMAIL", "TRANGTHAI", "CREATED_BY", "CREATED_DATE", "UPDATE_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    230   �9      �          0    16542    tb.TANGLUONG 
   TABLE DATA           �   COPY public."tb.TANGLUONG" ("MATL", "IDNV", "LUONGCU", "LUONGMOI", "NGAYLENLUONG", "NGAYLAP", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    241   �9      �          0    16404 	   tb.THAMSO 
   TABLE DATA           �   COPY public."tb.THAMSO" ("STT", "TUOINAMBD", "TUOINAMKT", "TUOINUBD", "TUOINUKT", "PHANTRAMBHYT", "PHANTRAMBHXH", "TRANGTHAI") FROM stdin;
    public          postgres    false    219   �9      �          0    24631    tb.THANGCHUC 
   TABLE DATA           �   COPY public."tb.THANGCHUC" ("SOQD", "IDNV", "HOTEN", "NGAYLAP", "NGAYAPDUNG", "IDPB", "IDCV1", "LYDO", "TRANGTHAI") FROM stdin;
    public          postgres    false    269   :      �          0    16564    tb.THOIVIEC 
   TABLE DATA           �   COPY public."tb.THOIVIEC" ("HDTV", "IDNV", "NGAYNOPDON", "NGAYNGHI", "LYDO", "GHICHU", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE", "TRANGTHAI") FROM stdin;
    public          postgres    false    244   :      �          0    16634    tb.UNGLUONG 
   TABLE DATA           �   COPY public."tb.UNGLUONG" ("STT", "IDNV", "NGAYTAO", "MAKYCONG", "SOTIEN", "LYDO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE", "TRANGTHAI") FROM stdin;
    public          postgres    false    250   ;:      7           0    0    THAMSO_STT_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."THAMSO_STT_seq"', 1, false);
          public          postgres    false    214            8           0    0    THAMSO_TUOINAMBD_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."THAMSO_TUOINAMBD_seq"', 1, false);
          public          postgres    false    215            9           0    0    THAMSO_TUOINAMKT_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."THAMSO_TUOINAMKT_seq"', 1, false);
          public          postgres    false    216            :           0    0    THAMSO_TUOINUBD_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."THAMSO_TUOINUBD_seq"', 1, false);
          public          postgres    false    217            ;           0    0    THAMSO_TUOINUKT_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."THAMSO_TUOINUKT_seq"', 1, false);
          public          postgres    false    218            <           0    0    tb.BANGLUONG_ID_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.BANGLUONG_ID_seq"', 1, false);
          public          postgres    false    262            =           0    0    tb.BANGLUONG_MAKYCONG_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.BANGLUONG_MAKYCONG_seq"', 1, false);
          public          postgres    false    263            >           0    0    tb.CHUCVU_IDCV_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.CHUCVU_IDCV_seq"', 1, false);
          public          postgres    false    222            ?           0    0     tb.DIEUCHUYENTHANGCHUC_IDCV1_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq"', 1, false);
          public          postgres    false    252            @           0    0     tb.DIEUCHUYENTHANGCHUC_IDCV2_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq"', 1, false);
          public          postgres    false    254            A           0    0     tb.DIEUCHUYENTHANGCHUC_IDPB1_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq"', 1, false);
          public          postgres    false    251            B           0    0     tb.DIEUCHUYENTHANGCHUC_IDPB2_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq"', 1, false);
          public          postgres    false    253            C           0    0    tb.HOPDONGLAODONG_THOIHAN_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public."tb.HOPDONGLAODONG_THOIHAN_seq"', 1, false);
          public          postgres    false    242            D           0    0    tb.KYCONG_MAKYCONG_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."tb.KYCONG_MAKYCONG_seq"', 1, false);
          public          postgres    false    257            E           0    0    tb.KYCONG_NAM_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."tb.KYCONG_NAM_seq"', 1, false);
          public          postgres    false    259            F           0    0    tb.KYCONG_NGAYCONGTHANG_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."tb.KYCONG_NGAYCONGTHANG_seq"', 1, false);
          public          postgres    false    260            G           0    0    tb.KYCONG_THANG_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.KYCONG_THANG_seq"', 1, false);
          public          postgres    false    258            H           0    0    tb.LOAICA_IDLC_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.LOAICA_IDLC_seq"', 1, false);
          public          postgres    false    224            I           0    0    tb.LOAICONG_IDLCONG_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."tb.LOAICONG_IDLCONG_seq"', 1, false);
          public          postgres    false    226            J           0    0    tb.NHANVIENBAOHIEM_BH_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.NHANVIENBAOHIEM_BH_seq"', 1, false);
          public          postgres    false    245            K           0    0    tb.NHANVIENPHUCAP_IDPC_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_IDPC_seq"', 1, false);
          public          postgres    false    232            L           0    0    tb.NHANVIENPHUCAP_ID_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_ID_seq"', 1, false);
          public          postgres    false    231            M           0    0    tb.NHANVIENPHUCAP_KYCONG_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_KYCONG_seq"', 1, false);
          public          postgres    false    236            N           0    0    tb.NHANVIENPHUCAP_NAM_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_NAM_seq"', 1, false);
          public          postgres    false    235            O           0    0    tb.NHANVIENPHUCAP_NGAY_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_NGAY_seq"', 1, false);
          public          postgres    false    233            P           0    0    tb.NHANVIENPHUCAP_THANG_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_THANG_seq"', 1, false);
          public          postgres    false    234            Q           0    0    tb.NHANVIEN_IDCV_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.NHANVIEN_IDCV_seq"', 1, false);
          public          postgres    false    239            R           0    0    tb.NHANVIEN_IDPB_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.NHANVIEN_IDPB_seq"', 1, false);
          public          postgres    false    238            S           0    0    tb.PHONGBAN_IDPB_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.PHONGBAN_IDPB_seq"', 1, false);
          public          postgres    false    220            T           0    0    tb.PHUCAP_IDPC_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.PHUCAP_IDPC_seq"', 1, false);
          public          postgres    false    228            U           0    0    tb.THANGCHUC_IDCV1_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."tb.THANGCHUC_IDCV1_seq"', 1, false);
          public          postgres    false    268            V           0    0    tb.THANGCHUC_IDPB_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."tb.THANGCHUC_IDPB_seq"', 1, false);
          public          postgres    false    267            W           0    0    tb.UNGLUONG_MAKYCONG_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."tb.UNGLUONG_MAKYCONG_seq"', 1, false);
          public          postgres    false    249            X           0    0    tb.UNGLUONG_NGAYTAO_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."tb.UNGLUONG_NGAYTAO_seq"', 1, false);
          public          postgres    false    248            Y           0    0    tb.UNGLUONG_STT_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.UNGLUONG_STT_seq"', 1, false);
          public          postgres    false    247                       2606    16699    tb.BANGLUONG PK_BANGLUONG 
   CONSTRAINT     _   ALTER TABLE ONLY public."tb.BANGLUONG"
    ADD CONSTRAINT "PK_BANGLUONG" PRIMARY KEY ("IDNV");
 G   ALTER TABLE ONLY public."tb.BANGLUONG" DROP CONSTRAINT "PK_BANGLUONG";
       public            postgres    false    264            �           2606    16443    tb.CHUCVU PK_CHUCVU 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.CHUCVU"
    ADD CONSTRAINT "PK_CHUCVU" PRIMARY KEY ("IDCV");
 A   ALTER TABLE ONLY public."tb.CHUCVU" DROP CONSTRAINT "PK_CHUCVU";
       public            postgres    false    223                       2606    16659    tb.DIEUCHUYEN PK_DIEUCHUYEN 
   CONSTRAINT     a   ALTER TABLE ONLY public."tb.DIEUCHUYEN"
    ADD CONSTRAINT "PK_DIEUCHUYEN" PRIMARY KEY ("SOQD");
 I   ALTER TABLE ONLY public."tb.DIEUCHUYEN" DROP CONSTRAINT "PK_DIEUCHUYEN";
       public            postgres    false    255                       2606    16553    tb.HOPDONGLAODONG PK_HOPDONG 
   CONSTRAINT     `   ALTER TABLE ONLY public."tb.HOPDONGLAODONG"
    ADD CONSTRAINT "PK_HOPDONG" PRIMARY KEY ("HD");
 J   ALTER TABLE ONLY public."tb.HOPDONGLAODONG" DROP CONSTRAINT "PK_HOPDONG";
       public            postgres    false    243                       2606    16669    tb.KHENTHUONG PK_KHENTHUONG 
   CONSTRAINT     a   ALTER TABLE ONLY public."tb.KHENTHUONG"
    ADD CONSTRAINT "PK_KHENTHUONG" PRIMARY KEY ("MAKT");
 I   ALTER TABLE ONLY public."tb.KHENTHUONG" DROP CONSTRAINT "PK_KHENTHUONG";
       public            postgres    false    256                       2606    16828    tb.KYCONG PK_KYCONG 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.KYCONG"
    ADD CONSTRAINT "PK_KYCONG" PRIMARY KEY ("MAKYCONG");
 A   ALTER TABLE ONLY public."tb.KYCONG" DROP CONSTRAINT "PK_KYCONG";
       public            postgres    false    261            "           2606    24622    tb.KYLUAT PK_KYLUAT 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.KYLUAT"
    ADD CONSTRAINT "PK_KYLUAT" PRIMARY KEY ("MAKL");
 A   ALTER TABLE ONLY public."tb.KYLUAT" DROP CONSTRAINT "PK_KYLUAT";
       public            postgres    false    266                        2606    16450    tb.LOAICA PK_LOAICA 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.LOAICA"
    ADD CONSTRAINT "PK_LOAICA" PRIMARY KEY ("IDLC");
 A   ALTER TABLE ONLY public."tb.LOAICA" DROP CONSTRAINT "PK_LOAICA";
       public            postgres    false    225                       2606    16457    tb.LOAICONG PK_LOAICONG 
   CONSTRAINT     `   ALTER TABLE ONLY public."tb.LOAICONG"
    ADD CONSTRAINT "PK_LOAICONG" PRIMARY KEY ("IDLCONG");
 E   ALTER TABLE ONLY public."tb.LOAICONG" DROP CONSTRAINT "PK_LOAICONG";
       public            postgres    false    227            
           2606    16515    tb.NHANVIEN PK_NHANVIEN 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "PK_NHANVIEN" PRIMARY KEY ("IDNV");
 E   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "PK_NHANVIEN";
       public            postgres    false    240                       2606    24579 (   tb.NHANVIENBAOHIEMYTE PK_NHANVIENBAOHIEM 
   CONSTRAINT     n   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMYTE"
    ADD CONSTRAINT "PK_NHANVIENBAOHIEM" PRIMARY KEY ("BHYT");
 V   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMYTE" DROP CONSTRAINT "PK_NHANVIENBAOHIEM";
       public            postgres    false    246                        2606    24605 /   tb.NHANVIENBAOHIEMXAHOI PK_NHANVIENBAOHIEMXAHOI 
   CONSTRAINT     u   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMXAHOI"
    ADD CONSTRAINT "PK_NHANVIENBAOHIEMXAHOI" PRIMARY KEY ("BHXH");
 ]   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMXAHOI" DROP CONSTRAINT "PK_NHANVIENBAOHIEMXAHOI";
       public            postgres    false    265            �           2606    16436    tb.PHONGBAN PK_PHONGBAN 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.PHONGBAN"
    ADD CONSTRAINT "PK_PHONGBAN" PRIMARY KEY ("IDPB");
 E   ALTER TABLE ONLY public."tb.PHONGBAN" DROP CONSTRAINT "PK_PHONGBAN";
       public            postgres    false    221                       2606    16471    tb.PHUCAP PK_PHUCAP 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.PHUCAP"
    ADD CONSTRAINT "PK_PHUCAP" PRIMARY KEY ("IDPC");
 A   ALTER TABLE ONLY public."tb.PHUCAP" DROP CONSTRAINT "PK_PHUCAP";
       public            postgres    false    229                       2606    16493    tb.NHANVIENPHUCAP PK_PHUCAPNV 
   CONSTRAINT     a   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP"
    ADD CONSTRAINT "PK_PHUCAPNV" PRIMARY KEY ("ID");
 K   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" DROP CONSTRAINT "PK_PHUCAPNV";
       public            postgres    false    237                       2606    16476    tb.TAIKHOAN PK_TAIKHOAN 
   CONSTRAINT     a   ALTER TABLE ONLY public."tb.TAIKHOAN"
    ADD CONSTRAINT "PK_TAIKHOAN" PRIMARY KEY ("TAIKHOAN");
 E   ALTER TABLE ONLY public."tb.TAIKHOAN" DROP CONSTRAINT "PK_TAIKHOAN";
       public            postgres    false    230                       2606    16546    tb.TANGLUONG PK_TANGLUONG 
   CONSTRAINT     _   ALTER TABLE ONLY public."tb.TANGLUONG"
    ADD CONSTRAINT "PK_TANGLUONG" PRIMARY KEY ("MATL");
 G   ALTER TABLE ONLY public."tb.TANGLUONG" DROP CONSTRAINT "PK_TANGLUONG";
       public            postgres    false    241            �           2606    16413    tb.THAMSO PK_THAMSO 
   CONSTRAINT     X   ALTER TABLE ONLY public."tb.THAMSO"
    ADD CONSTRAINT "PK_THAMSO" PRIMARY KEY ("STT");
 A   ALTER TABLE ONLY public."tb.THAMSO" DROP CONSTRAINT "PK_THAMSO";
       public            postgres    false    219            $           2606    24637    tb.THANGCHUC PK_THANGCHUC 
   CONSTRAINT     _   ALTER TABLE ONLY public."tb.THANGCHUC"
    ADD CONSTRAINT "PK_THANGCHUC" PRIMARY KEY ("SOQD");
 G   ALTER TABLE ONLY public."tb.THANGCHUC" DROP CONSTRAINT "PK_THANGCHUC";
       public            postgres    false    269                       2606    16568    tb.THOIVIEC PK_THOIVIEC 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.THOIVIEC"
    ADD CONSTRAINT "PK_THOIVIEC" PRIMARY KEY ("HDTV");
 E   ALTER TABLE ONLY public."tb.THOIVIEC" DROP CONSTRAINT "PK_THOIVIEC";
       public            postgres    false    244                       2606    16641    tb.UNGLUONG PK_UNGLUONG 
   CONSTRAINT     \   ALTER TABLE ONLY public."tb.UNGLUONG"
    ADD CONSTRAINT "PK_UNGLUONG" PRIMARY KEY ("STT");
 E   ALTER TABLE ONLY public."tb.UNGLUONG" DROP CONSTRAINT "PK_UNGLUONG";
       public            postgres    false    250                       2606    24577    tb.NHANVIEN UQ_NHANVIEN 
   CONSTRAINT     i   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "UQ_NHANVIEN" UNIQUE ("CMND") INCLUDE ("CMND");
 E   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "UQ_NHANVIEN";
       public            postgres    false    240            4           2606    16834     tb.BANGLUONG FK_BANGLUONG_KYCONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.BANGLUONG"
    ADD CONSTRAINT "FK_BANGLUONG_KYCONG" FOREIGN KEY ("MAKYCONG") REFERENCES public."tb.KYCONG"("MAKYCONG") NOT VALID;
 N   ALTER TABLE ONLY public."tb.BANGLUONG" DROP CONSTRAINT "FK_BANGLUONG_KYCONG";
       public          postgres    false    3356    261    264            5           2606    16839 "   tb.BANGLUONG FK_BANGLUONG_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.BANGLUONG"
    ADD CONSTRAINT "FK_BANGLUONG_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 P   ALTER TABLE ONLY public."tb.BANGLUONG" DROP CONSTRAINT "FK_BANGLUONG_NHANVIEN";
       public          postgres    false    240    3338    264            0           2606    16859 +   tb.DIEUCHUYEN FK_DIEUCHUYENTHANGCHUC_CHUCVU    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.DIEUCHUYEN"
    ADD CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_CHUCVU" FOREIGN KEY ("IDCV2") REFERENCES public."tb.CHUCVU"("IDCV") NOT VALID;
 Y   ALTER TABLE ONLY public."tb.DIEUCHUYEN" DROP CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_CHUCVU";
       public          postgres    false    3326    223    255            1           2606    16660 -   tb.DIEUCHUYEN FK_DIEUCHUYENTHANGCHUC_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.DIEUCHUYEN"
    ADD CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 [   ALTER TABLE ONLY public."tb.DIEUCHUYEN" DROP CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_NHANVIEN";
       public          postgres    false    3338    240    255            2           2606    16854 -   tb.DIEUCHUYEN FK_DIEUCHUYENTHANGCHUC_PHONGBAN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.DIEUCHUYEN"
    ADD CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_PHONGBAN" FOREIGN KEY ("IDPB2") REFERENCES public."tb.PHONGBAN"("IDPB") NOT VALID;
 [   ALTER TABLE ONLY public."tb.DIEUCHUYEN" DROP CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_PHONGBAN";
       public          postgres    false    255    221    3324            +           2606    16554 %   tb.HOPDONGLAODONG FK_HOPDONG_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.HOPDONGLAODONG"
    ADD CONSTRAINT "FK_HOPDONG_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 S   ALTER TABLE ONLY public."tb.HOPDONGLAODONG" DROP CONSTRAINT "FK_HOPDONG_NHANVIEN";
       public          postgres    false    240    243    3338            3           2606    16670 +   tb.KHENTHUONG FK_KHENTHUONG_KYLUAT_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.KHENTHUONG"
    ADD CONSTRAINT "FK_KHENTHUONG_KYLUAT_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 Y   ALTER TABLE ONLY public."tb.KHENTHUONG" DROP CONSTRAINT "FK_KHENTHUONG_KYLUAT_NHANVIEN";
       public          postgres    false    240    3338    256            7           2606    24623    tb.KYLUAT FK_KYLUAT_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.KYLUAT"
    ADD CONSTRAINT "FK_KYLUAT_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 J   ALTER TABLE ONLY public."tb.KYLUAT" DROP CONSTRAINT "FK_KYLUAT_NHANVIEN";
       public          postgres    false    240    3338    266            6           2606    24606 8   tb.NHANVIENBAOHIEMXAHOI FK_NHANVIENBAOHIEMXAHOI_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMXAHOI"
    ADD CONSTRAINT "FK_NHANVIENBAOHIEMXAHOI_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 f   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMXAHOI" DROP CONSTRAINT "FK_NHANVIENBAOHIEMXAHOI_NHANVIEN";
       public          postgres    false    240    265    3338            -           2606    24590 4   tb.NHANVIENBAOHIEMYTE FK_NHANVIENBAOHIEMYTE_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMYTE"
    ADD CONSTRAINT "FK_NHANVIENBAOHIEMYTE_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 b   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEMYTE" DROP CONSTRAINT "FK_NHANVIENBAOHIEMYTE_NHANVIEN";
       public          postgres    false    3338    246    240            &           2606    16718 ,   tb.NHANVIENPHUCAP FK_NHANVIENPHUCAP_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP"
    ADD CONSTRAINT "FK_NHANVIENPHUCAP_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 Z   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" DROP CONSTRAINT "FK_NHANVIENPHUCAP_NHANVIEN";
       public          postgres    false    240    237    3338            (           2606    16531    tb.NHANVIEN FK_NHANVIEN_CHUCVU    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "FK_NHANVIEN_CHUCVU" FOREIGN KEY ("IDCV") REFERENCES public."tb.CHUCVU"("IDCV");
 L   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "FK_NHANVIEN_CHUCVU";
       public          postgres    false    223    3326    240            )           2606    16536     tb.NHANVIEN FK_NHANVIEN_PHONGBAN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "FK_NHANVIEN_PHONGBAN" FOREIGN KEY ("IDPB") REFERENCES public."tb.PHONGBAN"("IDPB");
 N   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "FK_NHANVIEN_PHONGBAN";
       public          postgres    false    3324    240    221            ,           2606    16569     tb.THOIVIEC FK_NHANVIEN_THOIVIEC    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.THOIVIEC"
    ADD CONSTRAINT "FK_NHANVIEN_THOIVIEC" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 N   ALTER TABLE ONLY public."tb.THOIVIEC" DROP CONSTRAINT "FK_NHANVIEN_THOIVIEC";
       public          postgres    false    3338    240    244            '           2606    16494 #   tb.NHANVIENPHUCAP FK_PHUCAPNHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP"
    ADD CONSTRAINT "FK_PHUCAPNHANVIEN" FOREIGN KEY ("IDPC") REFERENCES public."tb.PHUCAP"("IDPC") NOT VALID;
 Q   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" DROP CONSTRAINT "FK_PHUCAPNHANVIEN";
       public          postgres    false    237    229    3332            Z           0    0 5   CONSTRAINT "FK_PHUCAPNHANVIEN" ON "tb.NHANVIENPHUCAP"    COMMENT     m   COMMENT ON CONSTRAINT "FK_PHUCAPNHANVIEN" ON public."tb.NHANVIENPHUCAP" IS 'phụ cấp từng nhân viên';
          public          postgres    false    3367            %           2606    16822     tb.TAIKHOAN FK_TAIKHOAN_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.TAIKHOAN"
    ADD CONSTRAINT "FK_TAIKHOAN_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 N   ALTER TABLE ONLY public."tb.TAIKHOAN" DROP CONSTRAINT "FK_TAIKHOAN_NHANVIEN";
       public          postgres    false    3338    240    230            *           2606    24611 !   tb.TANGLUONG FK_TANGLUONG_HOPDONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.TANGLUONG"
    ADD CONSTRAINT "FK_TANGLUONG_HOPDONG" FOREIGN KEY ("IDNV") REFERENCES public."tb.HOPDONGLAODONG"("HD") NOT VALID;
 O   ALTER TABLE ONLY public."tb.TANGLUONG" DROP CONSTRAINT "FK_TANGLUONG_HOPDONG";
       public          postgres    false    241    243    3344            .           2606    16829    tb.UNGLUONG FK_UNGLUONG_KYCONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.UNGLUONG"
    ADD CONSTRAINT "FK_UNGLUONG_KYCONG" FOREIGN KEY ("MAKYCONG") REFERENCES public."tb.KYCONG"("MAKYCONG") NOT VALID;
 L   ALTER TABLE ONLY public."tb.UNGLUONG" DROP CONSTRAINT "FK_UNGLUONG_KYCONG";
       public          postgres    false    3356    261    250            /           2606    16642     tb.UNGLUONG FK_UNGLUONG_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.UNGLUONG"
    ADD CONSTRAINT "FK_UNGLUONG_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 N   ALTER TABLE ONLY public."tb.UNGLUONG" DROP CONSTRAINT "FK_UNGLUONG_NHANVIEN";
       public          postgres    false    250    3338    240            �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �     