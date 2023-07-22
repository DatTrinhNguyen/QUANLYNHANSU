PGDMP     )    "                {            QUANLYNHANSU    15.3    15.3 T   a           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            b           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            c           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            d           1262    16398    QUANLYNHANSU    DATABASE     �   CREATE DATABASE "QUANLYNHANSU" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'English_United States.1252';
    DROP DATABASE "QUANLYNHANSU";
                postgres    false            e           0    0    DATABASE "QUANLYNHANSU"    COMMENT     u   COMMENT ON DATABASE "QUANLYNHANSU" IS 'Phần mềm quản lý nhân sự đồ án môn Công nghệ phần mềm';
                   postgres    false    3684            �            1259    16404 	   tb.THAMSO    TABLE     �   CREATE TABLE public."tb.THAMSO" (
    "STT" smallint NOT NULL,
    "TUOINAMBD" smallint NOT NULL,
    "TUOINAMKT" smallint NOT NULL,
    "TUOINUBD" smallint NOT NULL,
    "TUOINUKT" smallint NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.THAMSO";
       public         heap    postgres    false            f           0    0    TABLE "tb.THAMSO"    COMMENT     M   COMMENT ON TABLE public."tb.THAMSO" IS 'Tham số chung của phần mềm';
          public          postgres    false    219            �            1259    16399    THAMSO_STT_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_STT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public."THAMSO_STT_seq";
       public          postgres    false    219            g           0    0    THAMSO_STT_seq    SEQUENCE OWNED BY     J   ALTER SEQUENCE public."THAMSO_STT_seq" OWNED BY public."tb.THAMSO"."STT";
          public          postgres    false    214            �            1259    16400    THAMSO_TUOINAMBD_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINAMBD_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."THAMSO_TUOINAMBD_seq";
       public          postgres    false    219            h           0    0    THAMSO_TUOINAMBD_seq    SEQUENCE OWNED BY     V   ALTER SEQUENCE public."THAMSO_TUOINAMBD_seq" OWNED BY public."tb.THAMSO"."TUOINAMBD";
          public          postgres    false    215            �            1259    16401    THAMSO_TUOINAMKT_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINAMKT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."THAMSO_TUOINAMKT_seq";
       public          postgres    false    219            i           0    0    THAMSO_TUOINAMKT_seq    SEQUENCE OWNED BY     V   ALTER SEQUENCE public."THAMSO_TUOINAMKT_seq" OWNED BY public."tb.THAMSO"."TUOINAMKT";
          public          postgres    false    216            �            1259    16402    THAMSO_TUOINUBD_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINUBD_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."THAMSO_TUOINUBD_seq";
       public          postgres    false    219            j           0    0    THAMSO_TUOINUBD_seq    SEQUENCE OWNED BY     T   ALTER SEQUENCE public."THAMSO_TUOINUBD_seq" OWNED BY public."tb.THAMSO"."TUOINUBD";
          public          postgres    false    217            �            1259    16403    THAMSO_TUOINUKT_seq    SEQUENCE     �   CREATE SEQUENCE public."THAMSO_TUOINUKT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."THAMSO_TUOINUKT_seq";
       public          postgres    false    219            k           0    0    THAMSO_TUOINUKT_seq    SEQUENCE OWNED BY     T   ALTER SEQUENCE public."THAMSO_TUOINUKT_seq" OWNED BY public."tb.THAMSO"."TUOINUKT";
          public          postgres    false    218                       1259    16703    tb.BANGCONGCHITIET    TABLE     -  CREATE TABLE public."tb.BANGCONGCHITIET" (
    "ID" bigint NOT NULL,
    "MAKYCONG" integer NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "NGAY" smallint NOT NULL,
    "THU" character varying(10) NOT NULL,
    "GIOVAO" time without time zone NOT NULL,
    "GIORA" time without time zone NOT NULL,
    "TANGCA" numeric(1,1) NOT NULL,
    "NGAYPHEP" bit(1) NOT NULL,
    "CONGLE" bit(1) NOT NULL,
    "CONGNHAT" bit(1) NOT NULL,
    "KYHIEU" character varying(10),
    "GHICHU" character varying(100)
);
 (   DROP TABLE public."tb.BANGCONGCHITIET";
       public         heap    postgres    false                       1259    16700    tb.BANGCONGCHITIET_ID_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BANGCONGCHITIET_ID_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.BANGCONGCHITIET_ID_seq";
       public          postgres    false    286            l           0    0    tb.BANGCONGCHITIET_ID_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.BANGCONGCHITIET_ID_seq" OWNED BY public."tb.BANGCONGCHITIET"."ID";
          public          postgres    false    283                       1259    16701    tb.BANGCONGCHITIET_MAKYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BANGCONGCHITIET_MAKYCONG_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 8   DROP SEQUENCE public."tb.BANGCONGCHITIET_MAKYCONG_seq";
       public          postgres    false    286            m           0    0    tb.BANGCONGCHITIET_MAKYCONG_seq    SEQUENCE OWNED BY     i   ALTER SEQUENCE public."tb.BANGCONGCHITIET_MAKYCONG_seq" OWNED BY public."tb.BANGCONGCHITIET"."MAKYCONG";
          public          postgres    false    284                       1259    16702    tb.BANGCONGCHITIET_NGAY_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BANGCONGCHITIET_NGAY_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public."tb.BANGCONGCHITIET_NGAY_seq";
       public          postgres    false    286            n           0    0    tb.BANGCONGCHITIET_NGAY_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public."tb.BANGCONGCHITIET_NGAY_seq" OWNED BY public."tb.BANGCONGCHITIET"."NGAY";
          public          postgres    false    285                       1259    16693    tb.BANGLUONG    TABLE       CREATE TABLE public."tb.BANGLUONG" (
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
       public         heap    postgres    false                       1259    16691    tb.BANGLUONG_ID_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BANGLUONG_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.BANGLUONG_ID_seq";
       public          postgres    false    282            o           0    0    tb.BANGLUONG_ID_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.BANGLUONG_ID_seq" OWNED BY public."tb.BANGLUONG"."ID";
          public          postgres    false    280                       1259    16692    tb.BANGLUONG_MAKYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BANGLUONG_MAKYCONG_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.BANGLUONG_MAKYCONG_seq";
       public          postgres    false    282            p           0    0    tb.BANGLUONG_MAKYCONG_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.BANGLUONG_MAKYCONG_seq" OWNED BY public."tb.BANGLUONG"."MAKYCONG";
          public          postgres    false    281                        1259    16583 
   tb.BAOHIEM    TABLE     j  CREATE TABLE public."tb.BAOHIEM" (
    "BH" smallint NOT NULL,
    "TENBH" character varying(35) NOT NULL,
    "HESO" numeric(2,3) NOT NULL,
    "TRANGTHAI" bit(1),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
     DROP TABLE public."tb.BAOHIEM";
       public         heap    postgres    false            �            1259    16582    tb.BAOHIEM_BH_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.BAOHIEM_BH_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."tb.BAOHIEM_BH_seq";
       public          postgres    false    256            q           0    0    tb.BAOHIEM_BH_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public."tb.BAOHIEM_BH_seq" OWNED BY public."tb.BAOHIEM"."BH";
          public          postgres    false    255            �            1259    16438 	   tb.CHUCVU    TABLE     �   CREATE TABLE public."tb.CHUCVU" (
    "IDCV" smallint NOT NULL,
    "TENCV" character varying(30) NOT NULL,
    "PCCV" numeric(10,3) NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.CHUCVU";
       public         heap    postgres    false            r           0    0    TABLE "tb.CHUCVU"    COMMENT     E   COMMENT ON TABLE public."tb.CHUCVU" IS 'Chức vụ trong công ty';
          public          postgres    false    227            �            1259    16437    tb.CHUCVU_IDCV_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.CHUCVU_IDCV_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.CHUCVU_IDCV_seq";
       public          postgres    false    227            s           0    0    tb.CHUCVU_IDCV_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.CHUCVU_IDCV_seq" OWNED BY public."tb.CHUCVU"."IDCV";
          public          postgres    false    226            �            1259    16415 	   tb.DANTOC    TABLE     �   CREATE TABLE public."tb.DANTOC" (
    "IDDT" smallint NOT NULL,
    "TENDT" character varying(30)[] NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.DANTOC";
       public         heap    postgres    false            t           0    0    TABLE "tb.DANTOC"    COMMENT     u   COMMENT ON TABLE public."tb.DANTOC" IS 'table DANTOC. Ghi nhận thông tin các dân tộc trong các nhân viên';
          public          postgres    false    221            �            1259    16414    tb.DANTOC_IDDT_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DANTOC_IDDT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.DANTOC_IDDT_seq";
       public          postgres    false    221            u           0    0    tb.DANTOC_IDDT_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.DANTOC_IDDT_seq" OWNED BY public."tb.DANTOC"."IDDT";
          public          postgres    false    220                       1259    16651    tb.DIEUCHUYENTHANGCHUC    TABLE     o  CREATE TABLE public."tb.DIEUCHUYENTHANGCHUC" (
    "SOQD" character varying(8) NOT NULL,
    "LOAIQD" bit(1) NOT NULL,
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
    "DELETED_DATE" date
);
 ,   DROP TABLE public."tb.DIEUCHUYENTHANGCHUC";
       public         heap    postgres    false                       1259    16648     tb.DIEUCHUYENTHANGCHUC_IDCV1_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq";
       public          postgres    false    273            v           0    0     tb.DIEUCHUYENTHANGCHUC_IDCV1_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq" OWNED BY public."tb.DIEUCHUYENTHANGCHUC"."IDCV1";
          public          postgres    false    270                       1259    16650     tb.DIEUCHUYENTHANGCHUC_IDCV2_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq";
       public          postgres    false    273            w           0    0     tb.DIEUCHUYENTHANGCHUC_IDCV2_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq" OWNED BY public."tb.DIEUCHUYENTHANGCHUC"."IDCV2";
          public          postgres    false    272                       1259    16647     tb.DIEUCHUYENTHANGCHUC_IDPB1_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq";
       public          postgres    false    273            x           0    0     tb.DIEUCHUYENTHANGCHUC_IDPB1_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq" OWNED BY public."tb.DIEUCHUYENTHANGCHUC"."IDPB1";
          public          postgres    false    269                       1259    16649     tb.DIEUCHUYENTHANGCHUC_IDPB2_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq";
       public          postgres    false    273            y           0    0     tb.DIEUCHUYENTHANGCHUC_IDPB2_seq    SEQUENCE OWNED BY     k   ALTER SEQUENCE public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq" OWNED BY public."tb.DIEUCHUYENTHANGCHUC"."IDPB2";
          public          postgres    false    271            �            1259    16548    tb.HOPDONGLAODONG    TABLE       CREATE TABLE public."tb.HOPDONGLAODONG" (
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
    "DELETED_DATE" date
);
 '   DROP TABLE public."tb.HOPDONGLAODONG";
       public         heap    postgres    false            z           0    0    TABLE "tb.HOPDONGLAODONG"    COMMENT     X   COMMENT ON TABLE public."tb.HOPDONGLAODONG" IS 'hợp đồng lao động nhân viên';
          public          postgres    false    252            �            1259    16547    tb.HOPDONGLAODONG_THOIHAN_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.HOPDONGLAODONG_THOIHAN_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public."tb.HOPDONGLAODONG_THOIHAN_seq";
       public          postgres    false    252            {           0    0    tb.HOPDONGLAODONG_THOIHAN_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public."tb.HOPDONGLAODONG_THOIHAN_seq" OWNED BY public."tb.HOPDONGLAODONG"."THOIHAN";
          public          postgres    false    251                       1259    16665    tb.KHENTHUONG_KYLUAT    TABLE     �  CREATE TABLE public."tb.KHENTHUONG_KYLUAT" (
    "QD" character varying(8) NOT NULL,
    "LOAIQD" date NOT NULL,
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
    "DELETED_DATE" date
);
 *   DROP TABLE public."tb.KHENTHUONG_KYLUAT";
       public         heap    postgres    false            |           0    0    TABLE "tb.KHENTHUONG_KYLUAT"    COMMENT     \   COMMENT ON TABLE public."tb.KHENTHUONG_KYLUAT" IS 'Khen thưởng kỷ luật nhân viên';
          public          postgres    false    274                       1259    16680 	   tb.KYCONG    TABLE     �  CREATE TABLE public."tb.KYCONG" (
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
       public         heap    postgres    false            }           0    0    TABLE "tb.KYCONG"    COMMENT     j   COMMENT ON TABLE public."tb.KYCONG" IS 'Kỳ công của nhân viên. Mỗi tháng là một kỳ công';
          public          postgres    false    279                       1259    16676    tb.KYCONG_MAKYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_MAKYCONG_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public."tb.KYCONG_MAKYCONG_seq";
       public          postgres    false    279            ~           0    0    tb.KYCONG_MAKYCONG_seq    SEQUENCE OWNED BY     W   ALTER SEQUENCE public."tb.KYCONG_MAKYCONG_seq" OWNED BY public."tb.KYCONG"."MAKYCONG";
          public          postgres    false    275                       1259    16678    tb.KYCONG_NAM_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_NAM_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public."tb.KYCONG_NAM_seq";
       public          postgres    false    279                       0    0    tb.KYCONG_NAM_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public."tb.KYCONG_NAM_seq" OWNED BY public."tb.KYCONG"."NAM";
          public          postgres    false    277                       1259    16679    tb.KYCONG_NGAYCONGTHANG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_NGAYCONGTHANG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public."tb.KYCONG_NGAYCONGTHANG_seq";
       public          postgres    false    279            �           0    0    tb.KYCONG_NGAYCONGTHANG_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public."tb.KYCONG_NGAYCONGTHANG_seq" OWNED BY public."tb.KYCONG"."NGAYCONGTHANG";
          public          postgres    false    278                       1259    16677    tb.KYCONG_THANG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.KYCONG_THANG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.KYCONG_THANG_seq";
       public          postgres    false    279            �           0    0    tb.KYCONG_THANG_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.KYCONG_THANG_seq" OWNED BY public."tb.KYCONG"."THANG";
          public          postgres    false    276            �            1259    16445 	   tb.LOAICA    TABLE     �   CREATE TABLE public."tb.LOAICA" (
    "IDLC" smallint NOT NULL,
    "TENLC" character varying(30) NOT NULL,
    "HESO" numeric(1,3) NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.LOAICA";
       public         heap    postgres    false            �           0    0    TABLE "tb.LOAICA"    COMMENT     A   COMMENT ON TABLE public."tb.LOAICA" IS 'Các ca trong công ty';
          public          postgres    false    229            �            1259    16444    tb.LOAICA_IDLC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.LOAICA_IDLC_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.LOAICA_IDLC_seq";
       public          postgres    false    229            �           0    0    tb.LOAICA_IDLC_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.LOAICA_IDLC_seq" OWNED BY public."tb.LOAICA"."IDLC";
          public          postgres    false    228            �            1259    16452    tb.LOAICONG    TABLE     �   CREATE TABLE public."tb.LOAICONG" (
    "IDLCONG" smallint NOT NULL,
    "TENLCONG" character varying(30) NOT NULL,
    "HESO" numeric(1,3) NOT NULL,
    "TRANGTHAI" boolean
);
 !   DROP TABLE public."tb.LOAICONG";
       public         heap    postgres    false            �           0    0    TABLE "tb.LOAICONG"    COMMENT     H   COMMENT ON TABLE public."tb.LOAICONG" IS 'loại công trong công ty';
          public          postgres    false    231            �            1259    16451    tb.LOAICONG_IDLCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.LOAICONG_IDLCONG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."tb.LOAICONG_IDLCONG_seq";
       public          postgres    false    231            �           0    0    tb.LOAICONG_IDLCONG_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public."tb.LOAICONG_IDLCONG_seq" OWNED BY public."tb.LOAICONG"."IDLCONG";
          public          postgres    false    230            �            1259    16504    tb.NHANVIEN    TABLE     �  CREATE TABLE public."tb.NHANVIEN" (
    "IDNV" character varying(10) NOT NULL,
    "HODEM" character varying(40) NOT NULL,
    "TEN" character varying(20) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "GIOITINH" bit(1) NOT NULL,
    "NGAYSINH" date NOT NULL,
    "IDDT" smallint NOT NULL,
    "IDTG" smallint NOT NULL,
    "IDTD" smallint NOT NULL,
    "CMND" character varying(15) NOT NULL,
    "HINHANH" bytea NOT NULL,
    "SDT" character varying(14) NOT NULL,
    "DIACHI" character varying(100) NOT NULL,
    "IDPB" smallint NOT NULL,
    "IDCV" smallint NOT NULL,
    "LUONG" numeric(10,3) NOT NULL,
    "HESO" numeric(1,3) NOT NULL,
    "NGAYGIANHAP" date NOT NULL,
    "TRANGTHAI" bit(1) NOT NULL,
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
 !   DROP TABLE public."tb.NHANVIEN";
       public         heap    postgres    false            �           0    0    TABLE "tb.NHANVIEN"    COMMENT     G   COMMENT ON TABLE public."tb.NHANVIEN" IS 'nhân viên trong công ty';
          public          postgres    false    249                       1259    16590    tb.NHANVIENBAOHIEM    TABLE     �  CREATE TABLE public."tb.NHANVIENBAOHIEM" (
    "HDBH" character varying(8) NOT NULL,
    "BH" smallint NOT NULL,
    "HD" character varying(8) NOT NULL,
    "NGAYLAP" date NOT NULL,
    "NGAYAPDUNG" date NOT NULL,
    "TRANGTHAI" bit(1),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
 (   DROP TABLE public."tb.NHANVIENBAOHIEM";
       public         heap    postgres    false                       1259    16589    tb.NHANVIENBAOHIEM_BH_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENBAOHIEM_BH_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.NHANVIENBAOHIEM_BH_seq";
       public          postgres    false    258            �           0    0    tb.NHANVIENBAOHIEM_BH_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.NHANVIENBAOHIEM_BH_seq" OWNED BY public."tb.NHANVIENBAOHIEM"."BH";
          public          postgres    false    257            �            1259    16483    tb.NHANVIENPHUCAP    TABLE        CREATE TABLE public."tb.NHANVIENPHUCAP" (
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
       public         heap    postgres    false            �           0    0    TABLE "tb.NHANVIENPHUCAP"    COMMENT     q   COMMENT ON TABLE public."tb.NHANVIENPHUCAP" IS 'các nhân viên nhận được phụ cấp của nhân viên';
          public          postgres    false    243            �            1259    16478    tb.NHANVIENPHUCAP_IDPC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_IDPC_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public."tb.NHANVIENPHUCAP_IDPC_seq";
       public          postgres    false    243            �           0    0    tb.NHANVIENPHUCAP_IDPC_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_IDPC_seq" OWNED BY public."tb.NHANVIENPHUCAP"."IDPC";
          public          postgres    false    238            �            1259    16477    tb.NHANVIENPHUCAP_ID_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."tb.NHANVIENPHUCAP_ID_seq";
       public          postgres    false    243            �           0    0    tb.NHANVIENPHUCAP_ID_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_ID_seq" OWNED BY public."tb.NHANVIENPHUCAP"."ID";
          public          postgres    false    237            �            1259    16482    tb.NHANVIENPHUCAP_KYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_KYCONG_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public."tb.NHANVIENPHUCAP_KYCONG_seq";
       public          postgres    false    243            �           0    0    tb.NHANVIENPHUCAP_KYCONG_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_KYCONG_seq" OWNED BY public."tb.NHANVIENPHUCAP"."KYCONG";
          public          postgres    false    242            �            1259    16481    tb.NHANVIENPHUCAP_NAM_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_NAM_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.NHANVIENPHUCAP_NAM_seq";
       public          postgres    false    243            �           0    0    tb.NHANVIENPHUCAP_NAM_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_NAM_seq" OWNED BY public."tb.NHANVIENPHUCAP"."NAM";
          public          postgres    false    241            �            1259    16479    tb.NHANVIENPHUCAP_NGAY_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_NGAY_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 3   DROP SEQUENCE public."tb.NHANVIENPHUCAP_NGAY_seq";
       public          postgres    false    243            �           0    0    tb.NHANVIENPHUCAP_NGAY_seq    SEQUENCE OWNED BY     _   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_NGAY_seq" OWNED BY public."tb.NHANVIENPHUCAP"."NGAY";
          public          postgres    false    239            �            1259    16480    tb.NHANVIENPHUCAP_THANG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENPHUCAP_THANG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 4   DROP SEQUENCE public."tb.NHANVIENPHUCAP_THANG_seq";
       public          postgres    false    243            �           0    0    tb.NHANVIENPHUCAP_THANG_seq    SEQUENCE OWNED BY     a   ALTER SEQUENCE public."tb.NHANVIENPHUCAP_THANG_seq" OWNED BY public."tb.NHANVIENPHUCAP"."THANG";
          public          postgres    false    240            #           1259    16791    tb.NHANVIENXEPCA    TABLE     C  CREATE TABLE public."tb.NHANVIENXEPCA" (
    "ID" integer NOT NULL,
    "MAKCXC" integer NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "NGAY" smallint NOT NULL,
    "THU" character varying(10) NOT NULL,
    "IDLC" smallint NOT NULL,
    "IDLCONG" smallint NOT NULL
);
 &   DROP TABLE public."tb.NHANVIENXEPCA";
       public         heap    postgres    false            "           1259    16790    tb.NHANVIENXEPCA_IDLCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENXEPCA_IDLCONG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 5   DROP SEQUENCE public."tb.NHANVIENXEPCA_IDLCONG_seq";
       public          postgres    false    291            �           0    0    tb.NHANVIENXEPCA_IDLCONG_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public."tb.NHANVIENXEPCA_IDLCONG_seq" OWNED BY public."tb.NHANVIENXEPCA"."IDLCONG";
          public          postgres    false    290            !           1259    16789    tb.NHANVIENXEPCA_IDLC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENXEPCA_IDLC_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.NHANVIENXEPCA_IDLC_seq";
       public          postgres    false    291            �           0    0    tb.NHANVIENXEPCA_IDLC_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.NHANVIENXEPCA_IDLC_seq" OWNED BY public."tb.NHANVIENXEPCA"."IDLC";
          public          postgres    false    289                       1259    16787    tb.NHANVIENXEPCA_ID_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENXEPCA_ID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."tb.NHANVIENXEPCA_ID_seq";
       public          postgres    false    291            �           0    0    tb.NHANVIENXEPCA_ID_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public."tb.NHANVIENXEPCA_ID_seq" OWNED BY public."tb.NHANVIENXEPCA"."ID";
          public          postgres    false    287                        1259    16788    tb.NHANVIENXEPCA_NGAY_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIENXEPCA_NGAY_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 2   DROP SEQUENCE public."tb.NHANVIENXEPCA_NGAY_seq";
       public          postgres    false    291            �           0    0    tb.NHANVIENXEPCA_NGAY_seq    SEQUENCE OWNED BY     ]   ALTER SEQUENCE public."tb.NHANVIENXEPCA_NGAY_seq" OWNED BY public."tb.NHANVIENXEPCA"."NGAY";
          public          postgres    false    288            �            1259    16503    tb.NHANVIEN_IDCV_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIEN_IDCV_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.NHANVIEN_IDCV_seq";
       public          postgres    false    249            �           0    0    tb.NHANVIEN_IDCV_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.NHANVIEN_IDCV_seq" OWNED BY public."tb.NHANVIEN"."IDCV";
          public          postgres    false    248            �            1259    16499    tb.NHANVIEN_IDDT_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIEN_IDDT_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.NHANVIEN_IDDT_seq";
       public          postgres    false    249            �           0    0    tb.NHANVIEN_IDDT_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.NHANVIEN_IDDT_seq" OWNED BY public."tb.NHANVIEN"."IDDT";
          public          postgres    false    244            �            1259    16502    tb.NHANVIEN_IDPB_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIEN_IDPB_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.NHANVIEN_IDPB_seq";
       public          postgres    false    249            �           0    0    tb.NHANVIEN_IDPB_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.NHANVIEN_IDPB_seq" OWNED BY public."tb.NHANVIEN"."IDPB";
          public          postgres    false    247            �            1259    16501    tb.NHANVIEN_IDTD_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIEN_IDTD_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.NHANVIEN_IDTD_seq";
       public          postgres    false    249            �           0    0    tb.NHANVIEN_IDTD_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.NHANVIEN_IDTD_seq" OWNED BY public."tb.NHANVIEN"."IDTD";
          public          postgres    false    246            �            1259    16500    tb.NHANVIEN_IDTG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.NHANVIEN_IDTG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.NHANVIEN_IDTG_seq";
       public          postgres    false    249            �           0    0    tb.NHANVIEN_IDTG_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.NHANVIEN_IDTG_seq" OWNED BY public."tb.NHANVIEN"."IDTG";
          public          postgres    false    245            �            1259    16574    tb.PHANQUYEN    TABLE     c  CREATE TABLE public."tb.PHANQUYEN" (
    "TAIKHOAN" character varying(15) NOT NULL,
    "VAITRO" character varying(15),
    "CHUCNANG" character varying(15),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
 "   DROP TABLE public."tb.PHANQUYEN";
       public         heap    postgres    false            �           0    0    TABLE "tb.PHANQUYEN"    COMMENT     S   COMMENT ON TABLE public."tb.PHANQUYEN" IS 'Phân quyền cho từng tài khoản';
          public          postgres    false    254            �            1259    16431    tb.PHONGBAN    TABLE     �   CREATE TABLE public."tb.PHONGBAN" (
    "IDPB" smallint NOT NULL,
    "TENPB" character varying(30) NOT NULL,
    "PCPB" numeric(10,3) NOT NULL,
    "TRANGTHAI" boolean
);
 !   DROP TABLE public."tb.PHONGBAN";
       public         heap    postgres    false            �           0    0    TABLE "tb.PHONGBAN"    COMMENT     F   COMMENT ON TABLE public."tb.PHONGBAN" IS 'Phòng ban trong công ty';
          public          postgres    false    225            �            1259    16430    tb.PHONGBAN_IDPB_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.PHONGBAN_IDPB_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public."tb.PHONGBAN_IDPB_seq";
       public          postgres    false    225            �           0    0    tb.PHONGBAN_IDPB_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public."tb.PHONGBAN_IDPB_seq" OWNED BY public."tb.PHONGBAN"."IDPB";
          public          postgres    false    224            �            1259    16466 	   tb.PHUCAP    TABLE     �   CREATE TABLE public."tb.PHUCAP" (
    "IDPC" smallint NOT NULL,
    "TENPC" character varying(30) NOT NULL,
    "SOTIEN" numeric(10,3) NOT NULL,
    "TRANGTHAI" boolean
);
    DROP TABLE public."tb.PHUCAP";
       public         heap    postgres    false            �           0    0    TABLE "tb.PHUCAP"    COMMENT     E   COMMENT ON TABLE public."tb.PHUCAP" IS 'Phụ cấp trong công ty';
          public          postgres    false    235            �            1259    16465    tb.PHUCAP_IDPC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.PHUCAP_IDPC_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.PHUCAP_IDPC_seq";
       public          postgres    false    235            �           0    0    tb.PHUCAP_IDPC_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.PHUCAP_IDPC_seq" OWNED BY public."tb.PHUCAP"."IDPC";
          public          postgres    false    234            �            1259    16472    tb.TAIKHOAN    TABLE     �  CREATE TABLE public."tb.TAIKHOAN" (
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
       public         heap    postgres    false            �           0    0    TABLE "tb.TAIKHOAN"    COMMENT     r   COMMENT ON TABLE public."tb.TAIKHOAN" IS 'Tài khoản trong công ty và tài khoản dùng trong phần mềm';
          public          postgres    false    236            �            1259    16542    tb.TANGLUONG    TABLE     �  CREATE TABLE public."tb.TANGLUONG" (
    "QDTL" character varying(8) NOT NULL,
    "HD" character varying(8) NOT NULL,
    "HESOCU" numeric(1,3) NOT NULL,
    "HESOMOI" numeric(1,3) NOT NULL,
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
       public         heap    postgres    false            �           0    0    TABLE "tb.TANGLUONG"    COMMENT     G   COMMENT ON TABLE public."tb.TANGLUONG" IS 'Nhân viên tăng lương';
          public          postgres    false    250            �            1259    16564    tb.THOIVIEC    TABLE     �  CREATE TABLE public."tb.THOIVIEC" (
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
    "DELETED_DATE" date
);
 !   DROP TABLE public."tb.THOIVIEC";
       public         heap    postgres    false            �           0    0    TABLE "tb.THOIVIEC"    COMMENT     E   COMMENT ON TABLE public."tb.THOIVIEC" IS 'nhân viên thôi việc';
          public          postgres    false    253                       1259    16620    tb.TIENCONGMOTGIO    TABLE     �   CREATE TABLE public."tb.TIENCONGMOTGIO" (
    "ID" smallint NOT NULL,
    "IDNV" character varying(10) NOT NULL,
    "HOTEN" character varying(60) NOT NULL,
    "TIENCA" numeric(10,3) NOT NULL
);
 '   DROP TABLE public."tb.TIENCONGMOTGIO";
       public         heap    postgres    false            �           0    0    TABLE "tb.TIENCONGMOTGIO"    COMMENT     ]   COMMENT ON TABLE public."tb.TIENCONGMOTGIO" IS 'tiền công một giờ của nhân viên';
          public          postgres    false    264                       1259    16619    tb.TIENCONGMOTGIO_ID_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.TIENCONGMOTGIO_ID_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."tb.TIENCONGMOTGIO_ID_seq";
       public          postgres    false    264            �           0    0    tb.TIENCONGMOTGIO_ID_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."tb.TIENCONGMOTGIO_ID_seq" OWNED BY public."tb.TIENCONGMOTGIO"."ID";
          public          postgres    false    263            �            1259    16459 
   tb.TONGIAO    TABLE     �   CREATE TABLE public."tb.TONGIAO" (
    "IDTG" smallint NOT NULL,
    "TENTG" character varying(30) NOT NULL,
    "TRANGTHAI" boolean
);
     DROP TABLE public."tb.TONGIAO";
       public         heap    postgres    false            �           0    0    TABLE "tb.TONGIAO"    COMMENT     \   COMMENT ON TABLE public."tb.TONGIAO" IS 'Các tôn giáo của nhân viên trong công ty';
          public          postgres    false    233            �            1259    16458    tb.TONGIAO_IDTG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.TONGIAO_IDTG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.TONGIAO_IDTG_seq";
       public          postgres    false    233            �           0    0    tb.TONGIAO_IDTG_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.TONGIAO_IDTG_seq" OWNED BY public."tb.TONGIAO"."IDTG";
          public          postgres    false    232            �            1259    16424 
   tb.TRINHDO    TABLE     �   CREATE TABLE public."tb.TRINHDO" (
    "IDTD" smallint NOT NULL,
    "TENTD" character varying(30) NOT NULL,
    "TRANGTHAI" boolean
);
     DROP TABLE public."tb.TRINHDO";
       public         heap    postgres    false            �           0    0    TABLE "tb.TRINHDO"    COMMENT     X   COMMENT ON TABLE public."tb.TRINHDO" IS 'Trình độ các nhân viên trong công ty';
          public          postgres    false    223            �            1259    16423    tb.TRINHDO_IDTD_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.TRINHDO_IDTD_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.TRINHDO_IDTD_seq";
       public          postgres    false    223            �           0    0    tb.TRINHDO_IDTD_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.TRINHDO_IDTD_seq" OWNED BY public."tb.TRINHDO"."IDTD";
          public          postgres    false    222                       1259    16634    tb.UNGLUONG    TABLE     �  CREATE TABLE public."tb.UNGLUONG" (
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
    "DELETED_DATE" date
);
 !   DROP TABLE public."tb.UNGLUONG";
       public         heap    postgres    false            �           0    0    TABLE "tb.UNGLUONG"    COMMENT     F   COMMENT ON TABLE public."tb.UNGLUONG" IS 'Nhân viên ứng lương';
          public          postgres    false    268                       1259    16633    tb.UNGLUONG_MAKYCONG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.UNGLUONG_MAKYCONG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public."tb.UNGLUONG_MAKYCONG_seq";
       public          postgres    false    268            �           0    0    tb.UNGLUONG_MAKYCONG_seq    SEQUENCE OWNED BY     [   ALTER SEQUENCE public."tb.UNGLUONG_MAKYCONG_seq" OWNED BY public."tb.UNGLUONG"."MAKYCONG";
          public          postgres    false    267            
           1259    16632    tb.UNGLUONG_NGAYTAO_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.UNGLUONG_NGAYTAO_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 0   DROP SEQUENCE public."tb.UNGLUONG_NGAYTAO_seq";
       public          postgres    false    268            �           0    0    tb.UNGLUONG_NGAYTAO_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public."tb.UNGLUONG_NGAYTAO_seq" OWNED BY public."tb.UNGLUONG"."NGAYTAO";
          public          postgres    false    266            	           1259    16631    tb.UNGLUONG_STT_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.UNGLUONG_STT_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.UNGLUONG_STT_seq";
       public          postgres    false    268            �           0    0    tb.UNGLUONG_STT_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.UNGLUONG_STT_seq" OWNED BY public."tb.UNGLUONG"."STT";
          public          postgres    false    265                       1259    16610    tb.XEPCA    TABLE     �  CREATE TABLE public."tb.XEPCA" (
    "MAKCXC" integer NOT NULL,
    "THANG" smallint NOT NULL,
    "NAM" smallint NOT NULL,
    "NGAYTAO" date NOT NULL,
    "TRANGTHAI" bit(1),
    "KHOA" bit(1),
    "CREATED_BY" character varying(15),
    "CREATED_DATE" date,
    "UPDATED_BY" character varying(15),
    "UPDATED_DATE" date,
    "DELETED_BY" character varying(15),
    "DELETED_DATE" date
);
    DROP TABLE public."tb.XEPCA";
       public         heap    postgres    false            �           0    0    TABLE "tb.XEPCA"    COMMENT     B   COMMENT ON TABLE public."tb.XEPCA" IS 'xếp ca cho nhân viên';
          public          postgres    false    262                       1259    16607    tb.XEPCA_MAKCXC_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.XEPCA_MAKCXC_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public."tb.XEPCA_MAKCXC_seq";
       public          postgres    false    262            �           0    0    tb.XEPCA_MAKCXC_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public."tb.XEPCA_MAKCXC_seq" OWNED BY public."tb.XEPCA"."MAKCXC";
          public          postgres    false    259                       1259    16609    tb.XEPCA_NAM_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.XEPCA_NAM_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public."tb.XEPCA_NAM_seq";
       public          postgres    false    262            �           0    0    tb.XEPCA_NAM_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public."tb.XEPCA_NAM_seq" OWNED BY public."tb.XEPCA"."NAM";
          public          postgres    false    261                       1259    16608    tb.XEPCA_THANG_seq    SEQUENCE     �   CREATE SEQUENCE public."tb.XEPCA_THANG_seq"
    AS smallint
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public."tb.XEPCA_THANG_seq";
       public          postgres    false    262            �           0    0    tb.XEPCA_THANG_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public."tb.XEPCA_THANG_seq" OWNED BY public."tb.XEPCA"."THANG";
          public          postgres    false    260            +           2604    16706    tb.BANGCONGCHITIET ID    DEFAULT     �   ALTER TABLE ONLY public."tb.BANGCONGCHITIET" ALTER COLUMN "ID" SET DEFAULT nextval('public."tb.BANGCONGCHITIET_ID_seq"'::regclass);
 H   ALTER TABLE public."tb.BANGCONGCHITIET" ALTER COLUMN "ID" DROP DEFAULT;
       public          postgres    false    286    283    286            ,           2604    16707    tb.BANGCONGCHITIET MAKYCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.BANGCONGCHITIET" ALTER COLUMN "MAKYCONG" SET DEFAULT nextval('public."tb.BANGCONGCHITIET_MAKYCONG_seq"'::regclass);
 N   ALTER TABLE public."tb.BANGCONGCHITIET" ALTER COLUMN "MAKYCONG" DROP DEFAULT;
       public          postgres    false    286    284    286            -           2604    16708    tb.BANGCONGCHITIET NGAY    DEFAULT     �   ALTER TABLE ONLY public."tb.BANGCONGCHITIET" ALTER COLUMN "NGAY" SET DEFAULT nextval('public."tb.BANGCONGCHITIET_NGAY_seq"'::regclass);
 J   ALTER TABLE public."tb.BANGCONGCHITIET" ALTER COLUMN "NGAY" DROP DEFAULT;
       public          postgres    false    286    285    286            )           2604    16696    tb.BANGLUONG ID    DEFAULT     x   ALTER TABLE ONLY public."tb.BANGLUONG" ALTER COLUMN "ID" SET DEFAULT nextval('public."tb.BANGLUONG_ID_seq"'::regclass);
 B   ALTER TABLE public."tb.BANGLUONG" ALTER COLUMN "ID" DROP DEFAULT;
       public          postgres    false    282    280    282            *           2604    16697    tb.BANGLUONG MAKYCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.BANGLUONG" ALTER COLUMN "MAKYCONG" SET DEFAULT nextval('public."tb.BANGLUONG_MAKYCONG_seq"'::regclass);
 H   ALTER TABLE public."tb.BANGLUONG" ALTER COLUMN "MAKYCONG" DROP DEFAULT;
       public          postgres    false    281    282    282                       2604    16586    tb.BAOHIEM BH    DEFAULT     t   ALTER TABLE ONLY public."tb.BAOHIEM" ALTER COLUMN "BH" SET DEFAULT nextval('public."tb.BAOHIEM_BH_seq"'::regclass);
 @   ALTER TABLE public."tb.BAOHIEM" ALTER COLUMN "BH" DROP DEFAULT;
       public          postgres    false    256    255    256                       2604    16441    tb.CHUCVU IDCV    DEFAULT     v   ALTER TABLE ONLY public."tb.CHUCVU" ALTER COLUMN "IDCV" SET DEFAULT nextval('public."tb.CHUCVU_IDCV_seq"'::regclass);
 A   ALTER TABLE public."tb.CHUCVU" ALTER COLUMN "IDCV" DROP DEFAULT;
       public          postgres    false    227    226    227                       2604    16418    tb.DANTOC IDDT    DEFAULT     v   ALTER TABLE ONLY public."tb.DANTOC" ALTER COLUMN "IDDT" SET DEFAULT nextval('public."tb.DANTOC_IDDT_seq"'::regclass);
 A   ALTER TABLE public."tb.DANTOC" ALTER COLUMN "IDDT" DROP DEFAULT;
       public          postgres    false    220    221    221            !           2604    16654    tb.DIEUCHUYENTHANGCHUC IDPB1    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDPB1" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq"'::regclass);
 O   ALTER TABLE public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDPB1" DROP DEFAULT;
       public          postgres    false    269    273    273            "           2604    16655    tb.DIEUCHUYENTHANGCHUC IDCV1    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDCV1" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq"'::regclass);
 O   ALTER TABLE public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDCV1" DROP DEFAULT;
       public          postgres    false    273    270    273            #           2604    16656    tb.DIEUCHUYENTHANGCHUC IDPB2    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDPB2" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq"'::regclass);
 O   ALTER TABLE public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDPB2" DROP DEFAULT;
       public          postgres    false    271    273    273            $           2604    16657    tb.DIEUCHUYENTHANGCHUC IDCV2    DEFAULT     �   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDCV2" SET DEFAULT nextval('public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq"'::regclass);
 O   ALTER TABLE public."tb.DIEUCHUYENTHANGCHUC" ALTER COLUMN "IDCV2" DROP DEFAULT;
       public          postgres    false    272    273    273                       2604    16551    tb.HOPDONGLAODONG THOIHAN    DEFAULT     �   ALTER TABLE ONLY public."tb.HOPDONGLAODONG" ALTER COLUMN "THOIHAN" SET DEFAULT nextval('public."tb.HOPDONGLAODONG_THOIHAN_seq"'::regclass);
 L   ALTER TABLE public."tb.HOPDONGLAODONG" ALTER COLUMN "THOIHAN" DROP DEFAULT;
       public          postgres    false    252    251    252            %           2604    16684    tb.KYCONG MAKYCONG    DEFAULT     ~   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "MAKYCONG" SET DEFAULT nextval('public."tb.KYCONG_MAKYCONG_seq"'::regclass);
 E   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "MAKYCONG" DROP DEFAULT;
       public          postgres    false    275    279    279            &           2604    16685    tb.KYCONG THANG    DEFAULT     x   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "THANG" SET DEFAULT nextval('public."tb.KYCONG_THANG_seq"'::regclass);
 B   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "THANG" DROP DEFAULT;
       public          postgres    false    279    276    279            '           2604    16686    tb.KYCONG NAM    DEFAULT     t   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "NAM" SET DEFAULT nextval('public."tb.KYCONG_NAM_seq"'::regclass);
 @   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "NAM" DROP DEFAULT;
       public          postgres    false    277    279    279            (           2604    16687    tb.KYCONG NGAYCONGTHANG    DEFAULT     �   ALTER TABLE ONLY public."tb.KYCONG" ALTER COLUMN "NGAYCONGTHANG" SET DEFAULT nextval('public."tb.KYCONG_NGAYCONGTHANG_seq"'::regclass);
 J   ALTER TABLE public."tb.KYCONG" ALTER COLUMN "NGAYCONGTHANG" DROP DEFAULT;
       public          postgres    false    279    278    279                       2604    16448    tb.LOAICA IDLC    DEFAULT     v   ALTER TABLE ONLY public."tb.LOAICA" ALTER COLUMN "IDLC" SET DEFAULT nextval('public."tb.LOAICA_IDLC_seq"'::regclass);
 A   ALTER TABLE public."tb.LOAICA" ALTER COLUMN "IDLC" DROP DEFAULT;
       public          postgres    false    228    229    229            	           2604    16455    tb.LOAICONG IDLCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.LOAICONG" ALTER COLUMN "IDLCONG" SET DEFAULT nextval('public."tb.LOAICONG_IDLCONG_seq"'::regclass);
 F   ALTER TABLE public."tb.LOAICONG" ALTER COLUMN "IDLCONG" DROP DEFAULT;
       public          postgres    false    230    231    231                       2604    16507    tb.NHANVIEN IDDT    DEFAULT     z   ALTER TABLE ONLY public."tb.NHANVIEN" ALTER COLUMN "IDDT" SET DEFAULT nextval('public."tb.NHANVIEN_IDDT_seq"'::regclass);
 C   ALTER TABLE public."tb.NHANVIEN" ALTER COLUMN "IDDT" DROP DEFAULT;
       public          postgres    false    249    244    249                       2604    16508    tb.NHANVIEN IDTG    DEFAULT     z   ALTER TABLE ONLY public."tb.NHANVIEN" ALTER COLUMN "IDTG" SET DEFAULT nextval('public."tb.NHANVIEN_IDTG_seq"'::regclass);
 C   ALTER TABLE public."tb.NHANVIEN" ALTER COLUMN "IDTG" DROP DEFAULT;
       public          postgres    false    249    245    249                       2604    16509    tb.NHANVIEN IDTD    DEFAULT     z   ALTER TABLE ONLY public."tb.NHANVIEN" ALTER COLUMN "IDTD" SET DEFAULT nextval('public."tb.NHANVIEN_IDTD_seq"'::regclass);
 C   ALTER TABLE public."tb.NHANVIEN" ALTER COLUMN "IDTD" DROP DEFAULT;
       public          postgres    false    246    249    249                       2604    16510    tb.NHANVIEN IDPB    DEFAULT     z   ALTER TABLE ONLY public."tb.NHANVIEN" ALTER COLUMN "IDPB" SET DEFAULT nextval('public."tb.NHANVIEN_IDPB_seq"'::regclass);
 C   ALTER TABLE public."tb.NHANVIEN" ALTER COLUMN "IDPB" DROP DEFAULT;
       public          postgres    false    247    249    249                       2604    16511    tb.NHANVIEN IDCV    DEFAULT     z   ALTER TABLE ONLY public."tb.NHANVIEN" ALTER COLUMN "IDCV" SET DEFAULT nextval('public."tb.NHANVIEN_IDCV_seq"'::regclass);
 C   ALTER TABLE public."tb.NHANVIEN" ALTER COLUMN "IDCV" DROP DEFAULT;
       public          postgres    false    248    249    249                       2604    16593    tb.NHANVIENBAOHIEM BH    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEM" ALTER COLUMN "BH" SET DEFAULT nextval('public."tb.NHANVIENBAOHIEM_BH_seq"'::regclass);
 H   ALTER TABLE public."tb.NHANVIENBAOHIEM" ALTER COLUMN "BH" DROP DEFAULT;
       public          postgres    false    258    257    258                       2604    16486    tb.NHANVIENPHUCAP ID    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "ID" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_ID_seq"'::regclass);
 G   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "ID" DROP DEFAULT;
       public          postgres    false    243    237    243                       2604    16487    tb.NHANVIENPHUCAP IDPC    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "IDPC" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_IDPC_seq"'::regclass);
 I   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "IDPC" DROP DEFAULT;
       public          postgres    false    243    238    243                       2604    16488    tb.NHANVIENPHUCAP NGAY    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "NGAY" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_NGAY_seq"'::regclass);
 I   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "NGAY" DROP DEFAULT;
       public          postgres    false    243    239    243                       2604    16489    tb.NHANVIENPHUCAP THANG    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "THANG" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_THANG_seq"'::regclass);
 J   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "THANG" DROP DEFAULT;
       public          postgres    false    240    243    243                       2604    16490    tb.NHANVIENPHUCAP NAM    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "NAM" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_NAM_seq"'::regclass);
 H   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "NAM" DROP DEFAULT;
       public          postgres    false    243    241    243                       2604    16491    tb.NHANVIENPHUCAP KYCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" ALTER COLUMN "KYCONG" SET DEFAULT nextval('public."tb.NHANVIENPHUCAP_KYCONG_seq"'::regclass);
 K   ALTER TABLE public."tb.NHANVIENPHUCAP" ALTER COLUMN "KYCONG" DROP DEFAULT;
       public          postgres    false    243    242    243            .           2604    16794    tb.NHANVIENXEPCA ID    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" ALTER COLUMN "ID" SET DEFAULT nextval('public."tb.NHANVIENXEPCA_ID_seq"'::regclass);
 F   ALTER TABLE public."tb.NHANVIENXEPCA" ALTER COLUMN "ID" DROP DEFAULT;
       public          postgres    false    291    287    291            /           2604    16795    tb.NHANVIENXEPCA NGAY    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" ALTER COLUMN "NGAY" SET DEFAULT nextval('public."tb.NHANVIENXEPCA_NGAY_seq"'::regclass);
 H   ALTER TABLE public."tb.NHANVIENXEPCA" ALTER COLUMN "NGAY" DROP DEFAULT;
       public          postgres    false    291    288    291            0           2604    16796    tb.NHANVIENXEPCA IDLC    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" ALTER COLUMN "IDLC" SET DEFAULT nextval('public."tb.NHANVIENXEPCA_IDLC_seq"'::regclass);
 H   ALTER TABLE public."tb.NHANVIENXEPCA" ALTER COLUMN "IDLC" DROP DEFAULT;
       public          postgres    false    291    289    291            1           2604    16797    tb.NHANVIENXEPCA IDLCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" ALTER COLUMN "IDLCONG" SET DEFAULT nextval('public."tb.NHANVIENXEPCA_IDLCONG_seq"'::regclass);
 K   ALTER TABLE public."tb.NHANVIENXEPCA" ALTER COLUMN "IDLCONG" DROP DEFAULT;
       public          postgres    false    291    290    291                       2604    16434    tb.PHONGBAN IDPB    DEFAULT     z   ALTER TABLE ONLY public."tb.PHONGBAN" ALTER COLUMN "IDPB" SET DEFAULT nextval('public."tb.PHONGBAN_IDPB_seq"'::regclass);
 C   ALTER TABLE public."tb.PHONGBAN" ALTER COLUMN "IDPB" DROP DEFAULT;
       public          postgres    false    225    224    225                       2604    16469    tb.PHUCAP IDPC    DEFAULT     v   ALTER TABLE ONLY public."tb.PHUCAP" ALTER COLUMN "IDPC" SET DEFAULT nextval('public."tb.PHUCAP_IDPC_seq"'::regclass);
 A   ALTER TABLE public."tb.PHUCAP" ALTER COLUMN "IDPC" DROP DEFAULT;
       public          postgres    false    235    234    235            �           2604    16407    tb.THAMSO STT    DEFAULT     q   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "STT" SET DEFAULT nextval('public."THAMSO_STT_seq"'::regclass);
 @   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "STT" DROP DEFAULT;
       public          postgres    false    214    219    219                        2604    16408    tb.THAMSO TUOINAMBD    DEFAULT     }   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINAMBD" SET DEFAULT nextval('public."THAMSO_TUOINAMBD_seq"'::regclass);
 F   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINAMBD" DROP DEFAULT;
       public          postgres    false    219    215    219                       2604    16409    tb.THAMSO TUOINAMKT    DEFAULT     }   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINAMKT" SET DEFAULT nextval('public."THAMSO_TUOINAMKT_seq"'::regclass);
 F   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINAMKT" DROP DEFAULT;
       public          postgres    false    216    219    219                       2604    16410    tb.THAMSO TUOINUBD    DEFAULT     {   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINUBD" SET DEFAULT nextval('public."THAMSO_TUOINUBD_seq"'::regclass);
 E   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINUBD" DROP DEFAULT;
       public          postgres    false    219    217    219                       2604    16411    tb.THAMSO TUOINUKT    DEFAULT     {   ALTER TABLE ONLY public."tb.THAMSO" ALTER COLUMN "TUOINUKT" SET DEFAULT nextval('public."THAMSO_TUOINUKT_seq"'::regclass);
 E   ALTER TABLE public."tb.THAMSO" ALTER COLUMN "TUOINUKT" DROP DEFAULT;
       public          postgres    false    218    219    219                       2604    16623    tb.TIENCONGMOTGIO ID    DEFAULT     �   ALTER TABLE ONLY public."tb.TIENCONGMOTGIO" ALTER COLUMN "ID" SET DEFAULT nextval('public."tb.TIENCONGMOTGIO_ID_seq"'::regclass);
 G   ALTER TABLE public."tb.TIENCONGMOTGIO" ALTER COLUMN "ID" DROP DEFAULT;
       public          postgres    false    263    264    264            
           2604    16462    tb.TONGIAO IDTG    DEFAULT     x   ALTER TABLE ONLY public."tb.TONGIAO" ALTER COLUMN "IDTG" SET DEFAULT nextval('public."tb.TONGIAO_IDTG_seq"'::regclass);
 B   ALTER TABLE public."tb.TONGIAO" ALTER COLUMN "IDTG" DROP DEFAULT;
       public          postgres    false    232    233    233                       2604    16427    tb.TRINHDO IDTD    DEFAULT     x   ALTER TABLE ONLY public."tb.TRINHDO" ALTER COLUMN "IDTD" SET DEFAULT nextval('public."tb.TRINHDO_IDTD_seq"'::regclass);
 B   ALTER TABLE public."tb.TRINHDO" ALTER COLUMN "IDTD" DROP DEFAULT;
       public          postgres    false    223    222    223                       2604    16637    tb.UNGLUONG STT    DEFAULT     x   ALTER TABLE ONLY public."tb.UNGLUONG" ALTER COLUMN "STT" SET DEFAULT nextval('public."tb.UNGLUONG_STT_seq"'::regclass);
 B   ALTER TABLE public."tb.UNGLUONG" ALTER COLUMN "STT" DROP DEFAULT;
       public          postgres    false    265    268    268                       2604    16638    tb.UNGLUONG NGAYTAO    DEFAULT     �   ALTER TABLE ONLY public."tb.UNGLUONG" ALTER COLUMN "NGAYTAO" SET DEFAULT nextval('public."tb.UNGLUONG_NGAYTAO_seq"'::regclass);
 F   ALTER TABLE public."tb.UNGLUONG" ALTER COLUMN "NGAYTAO" DROP DEFAULT;
       public          postgres    false    266    268    268                        2604    16639    tb.UNGLUONG MAKYCONG    DEFAULT     �   ALTER TABLE ONLY public."tb.UNGLUONG" ALTER COLUMN "MAKYCONG" SET DEFAULT nextval('public."tb.UNGLUONG_MAKYCONG_seq"'::regclass);
 G   ALTER TABLE public."tb.UNGLUONG" ALTER COLUMN "MAKYCONG" DROP DEFAULT;
       public          postgres    false    267    268    268                       2604    16614    tb.XEPCA MAKCXC    DEFAULT     x   ALTER TABLE ONLY public."tb.XEPCA" ALTER COLUMN "MAKCXC" SET DEFAULT nextval('public."tb.XEPCA_MAKCXC_seq"'::regclass);
 B   ALTER TABLE public."tb.XEPCA" ALTER COLUMN "MAKCXC" DROP DEFAULT;
       public          postgres    false    259    262    262                       2604    16615    tb.XEPCA THANG    DEFAULT     v   ALTER TABLE ONLY public."tb.XEPCA" ALTER COLUMN "THANG" SET DEFAULT nextval('public."tb.XEPCA_THANG_seq"'::regclass);
 A   ALTER TABLE public."tb.XEPCA" ALTER COLUMN "THANG" DROP DEFAULT;
       public          postgres    false    262    260    262                       2604    16616    tb.XEPCA NAM    DEFAULT     r   ALTER TABLE ONLY public."tb.XEPCA" ALTER COLUMN "NAM" SET DEFAULT nextval('public."tb.XEPCA_NAM_seq"'::regclass);
 ?   ALTER TABLE public."tb.XEPCA" ALTER COLUMN "NAM" DROP DEFAULT;
       public          postgres    false    262    261    262            Y          0    16703    tb.BANGCONGCHITIET 
   TABLE DATA           �   COPY public."tb.BANGCONGCHITIET" ("ID", "MAKYCONG", "IDNV", "HOTEN", "NGAY", "THU", "GIOVAO", "GIORA", "TANGCA", "NGAYPHEP", "CONGLE", "CONGNHAT", "KYHIEU", "GHICHU") FROM stdin;
    public          postgres    false    286   Ů      U          0    16693    tb.BANGLUONG 
   TABLE DATA           �   COPY public."tb.BANGLUONG" ("ID", "MAKYCONG", "IDNV", "HOTEN", "NGAYCONG", "NGAYNGHI", "NGHIKHONGPHEP", "CONGLE", "CONGNHAT", "TANGCA", "THUCLANH", "CREATED_BY", "CREATED_DATE") FROM stdin;
    public          postgres    false    282   �      ;          0    16583 
   tb.BAOHIEM 
   TABLE DATA           �   COPY public."tb.BAOHIEM" ("BH", "TENBH", "HESO", "TRANGTHAI", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    256   ��                0    16438 	   tb.CHUCVU 
   TABLE DATA           K   COPY public."tb.CHUCVU" ("IDCV", "TENCV", "PCCV", "TRANGTHAI") FROM stdin;
    public          postgres    false    227   �                0    16415 	   tb.DANTOC 
   TABLE DATA           C   COPY public."tb.DANTOC" ("IDDT", "TENDT", "TRANGTHAI") FROM stdin;
    public          postgres    false    221   9�      L          0    16651    tb.DIEUCHUYENTHANGCHUC 
   TABLE DATA           �   COPY public."tb.DIEUCHUYENTHANGCHUC" ("SOQD", "LOAIQD", "IDNV", "HOTEN", "NGAYLAP", "NGAYAPDUNG", "IDPB1", "IDCV1", "IDPB2", "IDCV2", "LYDO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    273   V�      7          0    16548    tb.HOPDONGLAODONG 
   TABLE DATA           �   COPY public."tb.HOPDONGLAODONG" ("HD", "IDNV", "NGAYBATDAU", "NGAYKETTHUC", "THOIHAN", "NGAYKY", "LUONG", "HESO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    252   s�      M          0    16665    tb.KHENTHUONG_KYLUAT 
   TABLE DATA           �   COPY public."tb.KHENTHUONG_KYLUAT" ("QD", "LOAIQD", "IDNV", "HOTEN", "NGAYLAP", "SOTIEN", "LYDO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    274   ��      R          0    16680 	   tb.KYCONG 
   TABLE DATA           �   COPY public."tb.KYCONG" ("MAKYCONG", "THANG", "NAM", "NGAYTINHCONG", "NGAYCONGTHANG", "TRANGTHAI", "KHÓA", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    279   ��                 0    16445 	   tb.LOAICA 
   TABLE DATA           K   COPY public."tb.LOAICA" ("IDLC", "TENLC", "HESO", "TRANGTHAI") FROM stdin;
    public          postgres    false    229   ʯ      "          0    16452    tb.LOAICONG 
   TABLE DATA           S   COPY public."tb.LOAICONG" ("IDLCONG", "TENLCONG", "HESO", "TRANGTHAI") FROM stdin;
    public          postgres    false    231   �      4          0    16504    tb.NHANVIEN 
   TABLE DATA           3  COPY public."tb.NHANVIEN" ("IDNV", "HODEM", "TEN", "HOTEN", "GIOITINH", "NGAYSINH", "IDDT", "IDTG", "IDTD", "CMND", "HINHANH", "SDT", "DIACHI", "IDPB", "IDCV", "LUONG", "HESO", "NGAYGIANHAP", "TRANGTHAI", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    249   �      =          0    16590    tb.NHANVIENBAOHIEM 
   TABLE DATA           �   COPY public."tb.NHANVIENBAOHIEM" ("HDBH", "BH", "HD", "NGAYLAP", "NGAYAPDUNG", "TRANGTHAI", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    258   !�      .          0    16483    tb.NHANVIENPHUCAP 
   TABLE DATA           �   COPY public."tb.NHANVIENPHUCAP" ("ID", "IDNV", "IDPC", "NGAY", "THANG", "NAM", "KYCONG", "NOIDUNG", "SOTIEN", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    243   >�      ^          0    16791    tb.NHANVIENXEPCA 
   TABLE DATA           o   COPY public."tb.NHANVIENXEPCA" ("ID", "MAKCXC", "IDNV", "HOTEN", "NGAY", "THU", "IDLC", "IDLCONG") FROM stdin;
    public          postgres    false    291   [�      9          0    16574    tb.PHANQUYEN 
   TABLE DATA           �   COPY public."tb.PHANQUYEN" ("TAIKHOAN", "VAITRO", "CHUCNANG", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    254   x�                0    16431    tb.PHONGBAN 
   TABLE DATA           M   COPY public."tb.PHONGBAN" ("IDPB", "TENPB", "PCPB", "TRANGTHAI") FROM stdin;
    public          postgres    false    225   ��      &          0    16466 	   tb.PHUCAP 
   TABLE DATA           M   COPY public."tb.PHUCAP" ("IDPC", "TENPC", "SOTIEN", "TRANGTHAI") FROM stdin;
    public          postgres    false    235   ��      '          0    16472    tb.TAIKHOAN 
   TABLE DATA           �   COPY public."tb.TAIKHOAN" ("TAIKHOAN", "MATKHAU", "IDNV", "EMAIL", "TRANGTHAI", "CREATED_BY", "CREATED_DATE", "UPDATE_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    236   ϰ      5          0    16542    tb.TANGLUONG 
   TABLE DATA           �   COPY public."tb.TANGLUONG" ("QDTL", "HD", "HESOCU", "HESOMOI", "NGAYLENLUONG", "NGAYLAP", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    250   �                0    16404 	   tb.THAMSO 
   TABLE DATA           k   COPY public."tb.THAMSO" ("STT", "TUOINAMBD", "TUOINAMKT", "TUOINUBD", "TUOINUKT", "TRANGTHAI") FROM stdin;
    public          postgres    false    219   	�      8          0    16564    tb.THOIVIEC 
   TABLE DATA           �   COPY public."tb.THOIVIEC" ("HDTV", "IDNV", "NGAYNOPDON", "NGAYNGHI", "LYDO", "GHICHU", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    253   &�      C          0    16620    tb.TIENCONGMOTGIO 
   TABLE DATA           N   COPY public."tb.TIENCONGMOTGIO" ("ID", "IDNV", "HOTEN", "TIENCA") FROM stdin;
    public          postgres    false    264   C�      $          0    16459 
   tb.TONGIAO 
   TABLE DATA           D   COPY public."tb.TONGIAO" ("IDTG", "TENTG", "TRANGTHAI") FROM stdin;
    public          postgres    false    233   `�                0    16424 
   tb.TRINHDO 
   TABLE DATA           D   COPY public."tb.TRINHDO" ("IDTD", "TENTD", "TRANGTHAI") FROM stdin;
    public          postgres    false    223   }�      G          0    16634    tb.UNGLUONG 
   TABLE DATA           �   COPY public."tb.UNGLUONG" ("STT", "IDNV", "NGAYTAO", "MAKYCONG", "SOTIEN", "LYDO", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    268   ��      A          0    16610    tb.XEPCA 
   TABLE DATA           �   COPY public."tb.XEPCA" ("MAKCXC", "THANG", "NAM", "NGAYTAO", "TRANGTHAI", "KHOA", "CREATED_BY", "CREATED_DATE", "UPDATED_BY", "UPDATED_DATE", "DELETED_BY", "DELETED_DATE") FROM stdin;
    public          postgres    false    262   ��      �           0    0    THAMSO_STT_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."THAMSO_STT_seq"', 1, false);
          public          postgres    false    214            �           0    0    THAMSO_TUOINAMBD_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."THAMSO_TUOINAMBD_seq"', 1, false);
          public          postgres    false    215            �           0    0    THAMSO_TUOINAMKT_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."THAMSO_TUOINAMKT_seq"', 1, false);
          public          postgres    false    216            �           0    0    THAMSO_TUOINUBD_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."THAMSO_TUOINUBD_seq"', 1, false);
          public          postgres    false    217            �           0    0    THAMSO_TUOINUKT_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."THAMSO_TUOINUKT_seq"', 1, false);
          public          postgres    false    218            �           0    0    tb.BANGCONGCHITIET_ID_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.BANGCONGCHITIET_ID_seq"', 1, false);
          public          postgres    false    283            �           0    0    tb.BANGCONGCHITIET_MAKYCONG_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('public."tb.BANGCONGCHITIET_MAKYCONG_seq"', 1, false);
          public          postgres    false    284            �           0    0    tb.BANGCONGCHITIET_NGAY_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."tb.BANGCONGCHITIET_NGAY_seq"', 1, false);
          public          postgres    false    285            �           0    0    tb.BANGLUONG_ID_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.BANGLUONG_ID_seq"', 1, false);
          public          postgres    false    280            �           0    0    tb.BANGLUONG_MAKYCONG_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.BANGLUONG_MAKYCONG_seq"', 1, false);
          public          postgres    false    281            �           0    0    tb.BAOHIEM_BH_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."tb.BAOHIEM_BH_seq"', 1, false);
          public          postgres    false    255            �           0    0    tb.CHUCVU_IDCV_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.CHUCVU_IDCV_seq"', 1, false);
          public          postgres    false    226            �           0    0    tb.DANTOC_IDDT_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.DANTOC_IDDT_seq"', 1, false);
          public          postgres    false    220            �           0    0     tb.DIEUCHUYENTHANGCHUC_IDCV1_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDCV1_seq"', 1, false);
          public          postgres    false    270            �           0    0     tb.DIEUCHUYENTHANGCHUC_IDCV2_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDCV2_seq"', 1, false);
          public          postgres    false    272            �           0    0     tb.DIEUCHUYENTHANGCHUC_IDPB1_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDPB1_seq"', 1, false);
          public          postgres    false    269            �           0    0     tb.DIEUCHUYENTHANGCHUC_IDPB2_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public."tb.DIEUCHUYENTHANGCHUC_IDPB2_seq"', 1, false);
          public          postgres    false    271            �           0    0    tb.HOPDONGLAODONG_THOIHAN_seq    SEQUENCE SET     N   SELECT pg_catalog.setval('public."tb.HOPDONGLAODONG_THOIHAN_seq"', 1, false);
          public          postgres    false    251            �           0    0    tb.KYCONG_MAKYCONG_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public."tb.KYCONG_MAKYCONG_seq"', 1, false);
          public          postgres    false    275            �           0    0    tb.KYCONG_NAM_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public."tb.KYCONG_NAM_seq"', 1, false);
          public          postgres    false    277            �           0    0    tb.KYCONG_NGAYCONGTHANG_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."tb.KYCONG_NGAYCONGTHANG_seq"', 1, false);
          public          postgres    false    278            �           0    0    tb.KYCONG_THANG_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.KYCONG_THANG_seq"', 1, false);
          public          postgres    false    276            �           0    0    tb.LOAICA_IDLC_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.LOAICA_IDLC_seq"', 1, false);
          public          postgres    false    228            �           0    0    tb.LOAICONG_IDLCONG_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."tb.LOAICONG_IDLCONG_seq"', 1, false);
          public          postgres    false    230            �           0    0    tb.NHANVIENBAOHIEM_BH_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.NHANVIENBAOHIEM_BH_seq"', 1, false);
          public          postgres    false    257            �           0    0    tb.NHANVIENPHUCAP_IDPC_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_IDPC_seq"', 1, false);
          public          postgres    false    238            �           0    0    tb.NHANVIENPHUCAP_ID_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_ID_seq"', 1, false);
          public          postgres    false    237            �           0    0    tb.NHANVIENPHUCAP_KYCONG_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_KYCONG_seq"', 1, false);
          public          postgres    false    242            �           0    0    tb.NHANVIENPHUCAP_NAM_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_NAM_seq"', 1, false);
          public          postgres    false    241            �           0    0    tb.NHANVIENPHUCAP_NGAY_seq    SEQUENCE SET     K   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_NGAY_seq"', 1, false);
          public          postgres    false    239            �           0    0    tb.NHANVIENPHUCAP_THANG_seq    SEQUENCE SET     L   SELECT pg_catalog.setval('public."tb.NHANVIENPHUCAP_THANG_seq"', 1, false);
          public          postgres    false    240            �           0    0    tb.NHANVIENXEPCA_IDLCONG_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public."tb.NHANVIENXEPCA_IDLCONG_seq"', 1, false);
          public          postgres    false    290            �           0    0    tb.NHANVIENXEPCA_IDLC_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.NHANVIENXEPCA_IDLC_seq"', 1, false);
          public          postgres    false    289            �           0    0    tb.NHANVIENXEPCA_ID_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."tb.NHANVIENXEPCA_ID_seq"', 1, false);
          public          postgres    false    287            �           0    0    tb.NHANVIENXEPCA_NGAY_seq    SEQUENCE SET     J   SELECT pg_catalog.setval('public."tb.NHANVIENXEPCA_NGAY_seq"', 1, false);
          public          postgres    false    288            �           0    0    tb.NHANVIEN_IDCV_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.NHANVIEN_IDCV_seq"', 1, false);
          public          postgres    false    248            �           0    0    tb.NHANVIEN_IDDT_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.NHANVIEN_IDDT_seq"', 1, false);
          public          postgres    false    244            �           0    0    tb.NHANVIEN_IDPB_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.NHANVIEN_IDPB_seq"', 1, false);
          public          postgres    false    247            �           0    0    tb.NHANVIEN_IDTD_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.NHANVIEN_IDTD_seq"', 1, false);
          public          postgres    false    246            �           0    0    tb.NHANVIEN_IDTG_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.NHANVIEN_IDTG_seq"', 1, false);
          public          postgres    false    245            �           0    0    tb.PHONGBAN_IDPB_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."tb.PHONGBAN_IDPB_seq"', 1, false);
          public          postgres    false    224            �           0    0    tb.PHUCAP_IDPC_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.PHUCAP_IDPC_seq"', 1, false);
          public          postgres    false    234            �           0    0    tb.TIENCONGMOTGIO_ID_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."tb.TIENCONGMOTGIO_ID_seq"', 1, false);
          public          postgres    false    263            �           0    0    tb.TONGIAO_IDTG_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.TONGIAO_IDTG_seq"', 1, false);
          public          postgres    false    232            �           0    0    tb.TRINHDO_IDTD_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.TRINHDO_IDTD_seq"', 1, false);
          public          postgres    false    222            �           0    0    tb.UNGLUONG_MAKYCONG_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public."tb.UNGLUONG_MAKYCONG_seq"', 1, false);
          public          postgres    false    267            �           0    0    tb.UNGLUONG_NGAYTAO_seq    SEQUENCE SET     H   SELECT pg_catalog.setval('public."tb.UNGLUONG_NGAYTAO_seq"', 1, false);
          public          postgres    false    266            �           0    0    tb.UNGLUONG_STT_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.UNGLUONG_STT_seq"', 1, false);
          public          postgres    false    265            �           0    0    tb.XEPCA_MAKCXC_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public."tb.XEPCA_MAKCXC_seq"', 1, false);
          public          postgres    false    259            �           0    0    tb.XEPCA_NAM_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."tb.XEPCA_NAM_seq"', 1, false);
          public          postgres    false    261            �           0    0    tb.XEPCA_THANG_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public."tb.XEPCA_THANG_seq"', 1, false);
          public          postgres    false    260            c           2606    16710 %   tb.BANGCONGCHITIET PK_BANGCONGCHITIET 
   CONSTRAINT     i   ALTER TABLE ONLY public."tb.BANGCONGCHITIET"
    ADD CONSTRAINT "PK_BANGCONGCHITIET" PRIMARY KEY ("ID");
 S   ALTER TABLE ONLY public."tb.BANGCONGCHITIET" DROP CONSTRAINT "PK_BANGCONGCHITIET";
       public            postgres    false    286            a           2606    16699    tb.BANGLUONG PK_BANGLUONG 
   CONSTRAINT     _   ALTER TABLE ONLY public."tb.BANGLUONG"
    ADD CONSTRAINT "PK_BANGLUONG" PRIMARY KEY ("IDNV");
 G   ALTER TABLE ONLY public."tb.BANGLUONG" DROP CONSTRAINT "PK_BANGLUONG";
       public            postgres    false    282            ;           2606    16443    tb.CHUCVU PK_CHUCVU 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.CHUCVU"
    ADD CONSTRAINT "PK_CHUCVU" PRIMARY KEY ("IDCV");
 A   ALTER TABLE ONLY public."tb.CHUCVU" DROP CONSTRAINT "PK_CHUCVU";
       public            postgres    false    227            5           2606    16422    tb.DANTOC PK_DANTOC 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.DANTOC"
    ADD CONSTRAINT "PK_DANTOC" PRIMARY KEY ("IDDT");
 A   ALTER TABLE ONLY public."tb.DANTOC" DROP CONSTRAINT "PK_DANTOC";
       public            postgres    false    221            [           2606    16659 -   tb.DIEUCHUYENTHANGCHUC PK_DIEUCHUYENTHANGCHUC 
   CONSTRAINT     s   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC"
    ADD CONSTRAINT "PK_DIEUCHUYENTHANGCHUC" PRIMARY KEY ("SOQD");
 [   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" DROP CONSTRAINT "PK_DIEUCHUYENTHANGCHUC";
       public            postgres    false    273            M           2606    16553    tb.HOPDONGLAODONG PK_HOPDONG 
   CONSTRAINT     `   ALTER TABLE ONLY public."tb.HOPDONGLAODONG"
    ADD CONSTRAINT "PK_HOPDONG" PRIMARY KEY ("HD");
 J   ALTER TABLE ONLY public."tb.HOPDONGLAODONG" DROP CONSTRAINT "PK_HOPDONG";
       public            postgres    false    252            ]           2606    16669 )   tb.KHENTHUONG_KYLUAT PK_KHENTHUONG_KYLUAT 
   CONSTRAINT     m   ALTER TABLE ONLY public."tb.KHENTHUONG_KYLUAT"
    ADD CONSTRAINT "PK_KHENTHUONG_KYLUAT" PRIMARY KEY ("QD");
 W   ALTER TABLE ONLY public."tb.KHENTHUONG_KYLUAT" DROP CONSTRAINT "PK_KHENTHUONG_KYLUAT";
       public            postgres    false    274            _           2606    16828    tb.KYCONG PK_KYCONG 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.KYCONG"
    ADD CONSTRAINT "PK_KYCONG" PRIMARY KEY ("MAKYCONG");
 A   ALTER TABLE ONLY public."tb.KYCONG" DROP CONSTRAINT "PK_KYCONG";
       public            postgres    false    279            =           2606    16450    tb.LOAICA PK_LOAICA 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.LOAICA"
    ADD CONSTRAINT "PK_LOAICA" PRIMARY KEY ("IDLC");
 A   ALTER TABLE ONLY public."tb.LOAICA" DROP CONSTRAINT "PK_LOAICA";
       public            postgres    false    229            ?           2606    16457    tb.LOAICONG PK_LOAICONG 
   CONSTRAINT     `   ALTER TABLE ONLY public."tb.LOAICONG"
    ADD CONSTRAINT "PK_LOAICONG" PRIMARY KEY ("IDLCONG");
 E   ALTER TABLE ONLY public."tb.LOAICONG" DROP CONSTRAINT "PK_LOAICONG";
       public            postgres    false    231            I           2606    16515    tb.NHANVIEN PK_NHANVIEN 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "PK_NHANVIEN" PRIMARY KEY ("IDNV");
 E   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "PK_NHANVIEN";
       public            postgres    false    249            S           2606    16595 %   tb.NHANVIENBAOHIEM PK_NHANVIENBAOHIEM 
   CONSTRAINT     k   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEM"
    ADD CONSTRAINT "PK_NHANVIENBAOHIEM" PRIMARY KEY ("HDBH");
 S   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEM" DROP CONSTRAINT "PK_NHANVIENBAOHIEM";
       public            postgres    false    258            e           2606    16799 !   tb.NHANVIENXEPCA PK_NHANVIENXEPCA 
   CONSTRAINT     e   ALTER TABLE ONLY public."tb.NHANVIENXEPCA"
    ADD CONSTRAINT "PK_NHANVIENXEPCA" PRIMARY KEY ("ID");
 O   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" DROP CONSTRAINT "PK_NHANVIENXEPCA";
       public            postgres    false    291            9           2606    16436    tb.PHONGBAN PK_PHONGBAN 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.PHONGBAN"
    ADD CONSTRAINT "PK_PHONGBAN" PRIMARY KEY ("IDPB");
 E   ALTER TABLE ONLY public."tb.PHONGBAN" DROP CONSTRAINT "PK_PHONGBAN";
       public            postgres    false    225            C           2606    16471    tb.PHUCAP PK_PHUCAP 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.PHUCAP"
    ADD CONSTRAINT "PK_PHUCAP" PRIMARY KEY ("IDPC");
 A   ALTER TABLE ONLY public."tb.PHUCAP" DROP CONSTRAINT "PK_PHUCAP";
       public            postgres    false    235            G           2606    16493    tb.NHANVIENPHUCAP PK_PHUCAPNV 
   CONSTRAINT     a   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP"
    ADD CONSTRAINT "PK_PHUCAPNV" PRIMARY KEY ("ID");
 K   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" DROP CONSTRAINT "PK_PHUCAPNV";
       public            postgres    false    243            E           2606    16476    tb.TAIKHOAN PK_TAIKHOAN 
   CONSTRAINT     a   ALTER TABLE ONLY public."tb.TAIKHOAN"
    ADD CONSTRAINT "PK_TAIKHOAN" PRIMARY KEY ("TAIKHOAN");
 E   ALTER TABLE ONLY public."tb.TAIKHOAN" DROP CONSTRAINT "PK_TAIKHOAN";
       public            postgres    false    236            K           2606    16546    tb.TANGLUONG PK_TANGLUONG 
   CONSTRAINT     _   ALTER TABLE ONLY public."tb.TANGLUONG"
    ADD CONSTRAINT "PK_TANGLUONG" PRIMARY KEY ("QDTL");
 G   ALTER TABLE ONLY public."tb.TANGLUONG" DROP CONSTRAINT "PK_TANGLUONG";
       public            postgres    false    250            3           2606    16413    tb.THAMSO PK_THAMSO 
   CONSTRAINT     X   ALTER TABLE ONLY public."tb.THAMSO"
    ADD CONSTRAINT "PK_THAMSO" PRIMARY KEY ("STT");
 A   ALTER TABLE ONLY public."tb.THAMSO" DROP CONSTRAINT "PK_THAMSO";
       public            postgres    false    219            O           2606    16568    tb.THOIVIEC PK_THOIVIEC 
   CONSTRAINT     ]   ALTER TABLE ONLY public."tb.THOIVIEC"
    ADD CONSTRAINT "PK_THOIVIEC" PRIMARY KEY ("HDTV");
 E   ALTER TABLE ONLY public."tb.THOIVIEC" DROP CONSTRAINT "PK_THOIVIEC";
       public            postgres    false    253            W           2606    16625 %   tb.TIENCONGMOTGIO PK_TIENCONGNHANVIEN 
   CONSTRAINT     k   ALTER TABLE ONLY public."tb.TIENCONGMOTGIO"
    ADD CONSTRAINT "PK_TIENCONGNHANVIEN" PRIMARY KEY ("IDNV");
 S   ALTER TABLE ONLY public."tb.TIENCONGMOTGIO" DROP CONSTRAINT "PK_TIENCONGNHANVIEN";
       public            postgres    false    264            A           2606    16464    tb.TONGIAO PK_TONGIAO 
   CONSTRAINT     [   ALTER TABLE ONLY public."tb.TONGIAO"
    ADD CONSTRAINT "PK_TONGIAO" PRIMARY KEY ("IDTG");
 C   ALTER TABLE ONLY public."tb.TONGIAO" DROP CONSTRAINT "PK_TONGIAO";
       public            postgres    false    233            7           2606    16429    tb.TRINHDO PK_TRINHDO 
   CONSTRAINT     [   ALTER TABLE ONLY public."tb.TRINHDO"
    ADD CONSTRAINT "PK_TRINHDO" PRIMARY KEY ("IDTD");
 C   ALTER TABLE ONLY public."tb.TRINHDO" DROP CONSTRAINT "PK_TRINHDO";
       public            postgres    false    223            Y           2606    16641    tb.UNGLUONG PK_UNGLUONG 
   CONSTRAINT     \   ALTER TABLE ONLY public."tb.UNGLUONG"
    ADD CONSTRAINT "PK_UNGLUONG" PRIMARY KEY ("STT");
 E   ALTER TABLE ONLY public."tb.UNGLUONG" DROP CONSTRAINT "PK_UNGLUONG";
       public            postgres    false    268            U           2606    16816    tb.XEPCA PK_XEPCA 
   CONSTRAINT     Y   ALTER TABLE ONLY public."tb.XEPCA"
    ADD CONSTRAINT "PK_XEPCA" PRIMARY KEY ("MAKCXC");
 ?   ALTER TABLE ONLY public."tb.XEPCA" DROP CONSTRAINT "PK_XEPCA";
       public            postgres    false    262            Q           2606    16588    tb.BAOHIEM tb.BAOHIEM_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."tb.BAOHIEM"
    ADD CONSTRAINT "tb.BAOHIEM_pkey" PRIMARY KEY ("BH");
 H   ALTER TABLE ONLY public."tb.BAOHIEM" DROP CONSTRAINT "tb.BAOHIEM_pkey";
       public            postgres    false    256            }           2606    16849 +   tb.BANGCONGCHITIET FK_BANGCONGCHITET_KYCONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.BANGCONGCHITIET"
    ADD CONSTRAINT "FK_BANGCONGCHITET_KYCONG" FOREIGN KEY ("MAKYCONG") REFERENCES public."tb.KYCONG"("MAKYCONG") NOT VALID;
 Y   ALTER TABLE ONLY public."tb.BANGCONGCHITIET" DROP CONSTRAINT "FK_BANGCONGCHITET_KYCONG";
       public          postgres    false    279    286    3423            ~           2606    16844 .   tb.BANGCONGCHITIET FK_BANGCONGCHITIET_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.BANGCONGCHITIET"
    ADD CONSTRAINT "FK_BANGCONGCHITIET_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 \   ALTER TABLE ONLY public."tb.BANGCONGCHITIET" DROP CONSTRAINT "FK_BANGCONGCHITIET_NHANVIEN";
       public          postgres    false    249    286    3401            {           2606    16834     tb.BANGLUONG FK_BANGLUONG_KYCONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.BANGLUONG"
    ADD CONSTRAINT "FK_BANGLUONG_KYCONG" FOREIGN KEY ("MAKYCONG") REFERENCES public."tb.KYCONG"("MAKYCONG") NOT VALID;
 N   ALTER TABLE ONLY public."tb.BANGLUONG" DROP CONSTRAINT "FK_BANGLUONG_KYCONG";
       public          postgres    false    3423    279    282            |           2606    16839 "   tb.BANGLUONG FK_BANGLUONG_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.BANGLUONG"
    ADD CONSTRAINT "FK_BANGLUONG_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 P   ALTER TABLE ONLY public."tb.BANGLUONG" DROP CONSTRAINT "FK_BANGLUONG_NHANVIEN";
       public          postgres    false    249    282    3401            w           2606    16859 4   tb.DIEUCHUYENTHANGCHUC FK_DIEUCHUYENTHANGCHUC_CHUCVU    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC"
    ADD CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_CHUCVU" FOREIGN KEY ("IDCV2") REFERENCES public."tb.CHUCVU"("IDCV") NOT VALID;
 b   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" DROP CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_CHUCVU";
       public          postgres    false    273    3387    227            x           2606    16660 6   tb.DIEUCHUYENTHANGCHUC FK_DIEUCHUYENTHANGCHUC_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC"
    ADD CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 d   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" DROP CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_NHANVIEN";
       public          postgres    false    249    273    3401            y           2606    16854 6   tb.DIEUCHUYENTHANGCHUC FK_DIEUCHUYENTHANGCHUC_PHONGBAN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC"
    ADD CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_PHONGBAN" FOREIGN KEY ("IDPB2") REFERENCES public."tb.PHONGBAN"("IDPB") NOT VALID;
 d   ALTER TABLE ONLY public."tb.DIEUCHUYENTHANGCHUC" DROP CONSTRAINT "FK_DIEUCHUYENTHANGCHUC_PHONGBAN";
       public          postgres    false    273    225    3385            o           2606    16554 %   tb.HOPDONGLAODONG FK_HOPDONG_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.HOPDONGLAODONG"
    ADD CONSTRAINT "FK_HOPDONG_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 S   ALTER TABLE ONLY public."tb.HOPDONGLAODONG" DROP CONSTRAINT "FK_HOPDONG_NHANVIEN";
       public          postgres    false    3401    252    249            z           2606    16670 2   tb.KHENTHUONG_KYLUAT FK_KHENTHUONG_KYLUAT_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.KHENTHUONG_KYLUAT"
    ADD CONSTRAINT "FK_KHENTHUONG_KYLUAT_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 `   ALTER TABLE ONLY public."tb.KHENTHUONG_KYLUAT" DROP CONSTRAINT "FK_KHENTHUONG_KYLUAT_NHANVIEN";
       public          postgres    false    274    249    3401            r           2606    16596 -   tb.NHANVIENBAOHIEM FK_NHANVIENBAOHIEM_BAOHIEM    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEM"
    ADD CONSTRAINT "FK_NHANVIENBAOHIEM_BAOHIEM" FOREIGN KEY ("BH") REFERENCES public."tb.BAOHIEM"("BH");
 [   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEM" DROP CONSTRAINT "FK_NHANVIENBAOHIEM_BAOHIEM";
       public          postgres    false    3409    256    258            s           2606    16601 4   tb.NHANVIENBAOHIEM FK_NHANVIENBAOHIEM_HOPDONGLAODONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEM"
    ADD CONSTRAINT "FK_NHANVIENBAOHIEM_HOPDONGLAODONG" FOREIGN KEY ("HD") REFERENCES public."tb.HOPDONGLAODONG"("HD");
 b   ALTER TABLE ONLY public."tb.NHANVIENBAOHIEM" DROP CONSTRAINT "FK_NHANVIENBAOHIEM_HOPDONGLAODONG";
       public          postgres    false    3405    252    258            g           2606    16718 ,   tb.NHANVIENPHUCAP FK_NHANVIENPHUCAP_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP"
    ADD CONSTRAINT "FK_NHANVIENPHUCAP_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 Z   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" DROP CONSTRAINT "FK_NHANVIENPHUCAP_NHANVIEN";
       public          postgres    false    3401    243    249                       2606    16805 (   tb.NHANVIENXEPCA FK_NHANVIENXEPCA_LOAICA    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA"
    ADD CONSTRAINT "FK_NHANVIENXEPCA_LOAICA" FOREIGN KEY ("IDLC") REFERENCES public."tb.LOAICA"("IDLC");
 V   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" DROP CONSTRAINT "FK_NHANVIENXEPCA_LOAICA";
       public          postgres    false    291    3389    229            �           2606    16810 *   tb.NHANVIENXEPCA FK_NHANVIENXEPCA_LOAICONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA"
    ADD CONSTRAINT "FK_NHANVIENXEPCA_LOAICONG" FOREIGN KEY ("IDLCONG") REFERENCES public."tb.LOAICONG"("IDLCONG");
 X   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" DROP CONSTRAINT "FK_NHANVIENXEPCA_LOAICONG";
       public          postgres    false    231    3391    291            �           2606    16800 *   tb.NHANVIENXEPCA FK_NHANVIENXEPCA_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA"
    ADD CONSTRAINT "FK_NHANVIENXEPCA_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 X   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" DROP CONSTRAINT "FK_NHANVIENXEPCA_NHANVIEN";
       public          postgres    false    249    291    3401            �           2606    16817 '   tb.NHANVIENXEPCA FK_NHANVIENXEPCA_XEPCA    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENXEPCA"
    ADD CONSTRAINT "FK_NHANVIENXEPCA_XEPCA" FOREIGN KEY ("MAKCXC") REFERENCES public."tb.XEPCA"("MAKCXC") NOT VALID;
 U   ALTER TABLE ONLY public."tb.NHANVIENXEPCA" DROP CONSTRAINT "FK_NHANVIENXEPCA_XEPCA";
       public          postgres    false    262    3413    291            i           2606    16531    tb.NHANVIEN FK_NHANVIEN_CHUCVU    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "FK_NHANVIEN_CHUCVU" FOREIGN KEY ("IDCV") REFERENCES public."tb.CHUCVU"("IDCV");
 L   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "FK_NHANVIEN_CHUCVU";
       public          postgres    false    249    227    3387            j           2606    16516    tb.NHANVIEN FK_NHANVIEN_DANTOC    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "FK_NHANVIEN_DANTOC" FOREIGN KEY ("IDDT") REFERENCES public."tb.DANTOC"("IDDT");
 L   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "FK_NHANVIEN_DANTOC";
       public          postgres    false    249    221    3381            k           2606    16536     tb.NHANVIEN FK_NHANVIEN_PHONGBAN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "FK_NHANVIEN_PHONGBAN" FOREIGN KEY ("IDPB") REFERENCES public."tb.PHONGBAN"("IDPB");
 N   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "FK_NHANVIEN_PHONGBAN";
       public          postgres    false    3385    225    249            p           2606    16569     tb.THOIVIEC FK_NHANVIEN_THOIVIEC    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.THOIVIEC"
    ADD CONSTRAINT "FK_NHANVIEN_THOIVIEC" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 N   ALTER TABLE ONLY public."tb.THOIVIEC" DROP CONSTRAINT "FK_NHANVIEN_THOIVIEC";
       public          postgres    false    253    249    3401            l           2606    16521    tb.NHANVIEN FK_NHANVIEN_TONGIAO    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "FK_NHANVIEN_TONGIAO" FOREIGN KEY ("IDTG") REFERENCES public."tb.TONGIAO"("IDTG");
 M   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "FK_NHANVIEN_TONGIAO";
       public          postgres    false    3393    233    249            m           2606    16526    tb.NHANVIEN FK_NHANVIEN_TRINHDO    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIEN"
    ADD CONSTRAINT "FK_NHANVIEN_TRINHDO" FOREIGN KEY ("IDTD") REFERENCES public."tb.TRINHDO"("IDTD");
 M   ALTER TABLE ONLY public."tb.NHANVIEN" DROP CONSTRAINT "FK_NHANVIEN_TRINHDO";
       public          postgres    false    223    3383    249            q           2606    16577 "   tb.PHANQUYEN FK_PHANQUYEN_TAIKHOAN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.PHANQUYEN"
    ADD CONSTRAINT "FK_PHANQUYEN_TAIKHOAN" FOREIGN KEY ("TAIKHOAN") REFERENCES public."tb.TAIKHOAN"("TAIKHOAN");
 P   ALTER TABLE ONLY public."tb.PHANQUYEN" DROP CONSTRAINT "FK_PHANQUYEN_TAIKHOAN";
       public          postgres    false    3397    254    236            h           2606    16494 #   tb.NHANVIENPHUCAP FK_PHUCAPNHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP"
    ADD CONSTRAINT "FK_PHUCAPNHANVIEN" FOREIGN KEY ("IDPC") REFERENCES public."tb.PHUCAP"("IDPC") NOT VALID;
 Q   ALTER TABLE ONLY public."tb.NHANVIENPHUCAP" DROP CONSTRAINT "FK_PHUCAPNHANVIEN";
       public          postgres    false    235    243    3395            �           0    0 5   CONSTRAINT "FK_PHUCAPNHANVIEN" ON "tb.NHANVIENPHUCAP"    COMMENT     m   COMMENT ON CONSTRAINT "FK_PHUCAPNHANVIEN" ON public."tb.NHANVIENPHUCAP" IS 'phụ cấp từng nhân viên';
          public          postgres    false    3432            f           2606    16822     tb.TAIKHOAN FK_TAIKHOAN_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.TAIKHOAN"
    ADD CONSTRAINT "FK_TAIKHOAN_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV") NOT VALID;
 N   ALTER TABLE ONLY public."tb.TAIKHOAN" DROP CONSTRAINT "FK_TAIKHOAN_NHANVIEN";
       public          postgres    false    249    3401    236            n           2606    16559 !   tb.TANGLUONG FK_TANGLUONG_HOPDONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.TANGLUONG"
    ADD CONSTRAINT "FK_TANGLUONG_HOPDONG" FOREIGN KEY ("HD") REFERENCES public."tb.HOPDONGLAODONG"("HD") NOT VALID;
 O   ALTER TABLE ONLY public."tb.TANGLUONG" DROP CONSTRAINT "FK_TANGLUONG_HOPDONG";
       public          postgres    false    3405    252    250            t           2606    16626 &   tb.TIENCONGMOTGIO FK_TIENCONG_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.TIENCONGMOTGIO"
    ADD CONSTRAINT "FK_TIENCONG_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 T   ALTER TABLE ONLY public."tb.TIENCONGMOTGIO" DROP CONSTRAINT "FK_TIENCONG_NHANVIEN";
       public          postgres    false    249    3401    264            u           2606    16829    tb.UNGLUONG FK_UNGLUONG_KYCONG    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.UNGLUONG"
    ADD CONSTRAINT "FK_UNGLUONG_KYCONG" FOREIGN KEY ("MAKYCONG") REFERENCES public."tb.KYCONG"("MAKYCONG") NOT VALID;
 L   ALTER TABLE ONLY public."tb.UNGLUONG" DROP CONSTRAINT "FK_UNGLUONG_KYCONG";
       public          postgres    false    268    3423    279            v           2606    16642     tb.UNGLUONG FK_UNGLUONG_NHANVIEN    FK CONSTRAINT     �   ALTER TABLE ONLY public."tb.UNGLUONG"
    ADD CONSTRAINT "FK_UNGLUONG_NHANVIEN" FOREIGN KEY ("IDNV") REFERENCES public."tb.NHANVIEN"("IDNV");
 N   ALTER TABLE ONLY public."tb.UNGLUONG" DROP CONSTRAINT "FK_UNGLUONG_NHANVIEN";
       public          postgres    false    3401    268    249            Y      x������ � �      U      x������ � �      ;      x������ � �            x������ � �            x������ � �      L      x������ � �      7      x������ � �      M      x������ � �      R      x������ � �             x������ � �      "      x������ � �      4      x������ � �      =      x������ � �      .      x������ � �      ^      x������ � �      9      x������ � �            x������ � �      &      x������ � �      '      x������ � �      5      x������ � �            x������ � �      8      x������ � �      C      x������ � �      $      x������ � �            x������ � �      G      x������ � �      A      x������ � �     