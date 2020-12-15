PGDMP     )                    x            history    12.4    12.4     #           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            $           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            %           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            &           1262    49604    history    DATABASE     �   CREATE DATABASE history WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Russian_Russia.1251' LC_CTYPE = 'Russian_Russia.1251';
    DROP DATABASE history;
                postgres    false            �            1259    49605    articles    TABLE     �   CREATE TABLE public.articles (
    name text NOT NULL,
    image text,
    description text,
    keywords text,
    date_create date NOT NULL,
    id integer NOT NULL,
    article_text text
);
    DROP TABLE public.articles;
       public         heap    postgres    false            �            1259    49611    articles_id_seq    SEQUENCE     �   CREATE SEQUENCE public.articles_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.articles_id_seq;
       public          postgres    false    202            '           0    0    articles_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.articles_id_seq OWNED BY public.articles.id;
          public          postgres    false    203            �            1259    49613    books    TABLE     �   CREATE TABLE public.books (
    name text,
    author text,
    description text,
    write_date date,
    url text NOT NULL
);
    DROP TABLE public.books;
       public         heap    postgres    false            �            1259    49619    discussions    TABLE     �   CREATE TABLE public.discussions (
    message_text text,
    message_date timestamp without time zone,
    discussion_id integer,
    person_login text
);
    DROP TABLE public.discussions;
       public         heap    postgres    false            �            1259    49625    forum    TABLE     �   CREATE TABLE public.forum (
    person_create_login text,
    time_create timestamp without time zone,
    name text,
    description text,
    discussion_id integer NOT NULL
);
    DROP TABLE public.forum;
       public         heap    postgres    false            �            1259    49631    forum_discussion_id_seq    SEQUENCE     �   CREATE SEQUENCE public.forum_discussion_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public.forum_discussion_id_seq;
       public          postgres    false    206            (           0    0    forum_discussion_id_seq    SEQUENCE OWNED BY     S   ALTER SEQUENCE public.forum_discussion_id_seq OWNED BY public.forum.discussion_id;
          public          postgres    false    207            �            1259    49633    users    TABLE     `   CREATE TABLE public.users (
    login text,
    password text,
    selected_articles_id text
);
    DROP TABLE public.users;
       public         heap    postgres    false            �
           2604    49639    articles id    DEFAULT     j   ALTER TABLE ONLY public.articles ALTER COLUMN id SET DEFAULT nextval('public.articles_id_seq'::regclass);
 :   ALTER TABLE public.articles ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    203    202            �
           2604    49640    forum discussion_id    DEFAULT     z   ALTER TABLE ONLY public.forum ALTER COLUMN discussion_id SET DEFAULT nextval('public.forum_discussion_id_seq'::regclass);
 B   ALTER TABLE public.forum ALTER COLUMN discussion_id DROP DEFAULT;
       public          postgres    false    207    206                      0    49605    articles 
   TABLE DATA           e   COPY public.articles (name, image, description, keywords, date_create, id, article_text) FROM stdin;
    public          postgres    false    202   �                 0    49613    books 
   TABLE DATA           K   COPY public.books (name, author, description, write_date, url) FROM stdin;
    public          postgres    false    204   �+                 0    49619    discussions 
   TABLE DATA           ^   COPY public.discussions (message_text, message_date, discussion_id, person_login) FROM stdin;
    public          postgres    false    205   �,                 0    49625    forum 
   TABLE DATA           c   COPY public.forum (person_create_login, time_create, name, description, discussion_id) FROM stdin;
    public          postgres    false    206   �-                  0    49633    users 
   TABLE DATA           F   COPY public.users (login, password, selected_articles_id) FROM stdin;
    public          postgres    false    208   V.       )           0    0    articles_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.articles_id_seq', 5, true);
          public          postgres    false    203            *           0    0    forum_discussion_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.forum_discussion_id_seq', 19, true);
          public          postgres    false    207            �
           2606    49642    articles articles_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.articles
    ADD CONSTRAINT articles_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.articles DROP CONSTRAINT articles_pkey;
       public            postgres    false    202            �
           2606    49644    books books_pkey 
   CONSTRAINT     O   ALTER TABLE ONLY public.books
    ADD CONSTRAINT books_pkey PRIMARY KEY (url);
 :   ALTER TABLE ONLY public.books DROP CONSTRAINT books_pkey;
       public            postgres    false    204                  x��[�nב����\&����bV�.����vo|�#�,�} rH�4(�4%Ɗ$K$'Z��3Ӝ��~�ӯ�'٪�:}z8�zaK���>?���WUG�U��^��b�W���|��?�������b-�Ƴ�*��/�x��w�C��<����囀o/��Sy�Q�ascC���� ��d���H��N��%ȣ�u.���e�8�U�y,u�Y}�cY�`[s�Nw8��z��ƴ��{A~�q�����qw�{���ֽ5��gL�	�ޕ;�V��e�ʧ���<�������z;�_:q!ȸ�XȨ�l`*��Q���$���N��&�a����g��C�Y��2zίB���@'��.n8AOW���z��e�y`[��P�����Ǟ�0�{�P���d��~R�B�\����~�H�˴-Hk ��7Q� �R��ԏ��J�(�b'	I><��d<���駰�AT0���v��/?�2^��*5QϤ>���H�uY,���N��a�3_}�#��1d������+�C�RI����g_��>�$'�J��	�Y�G��8�(G�/t&���|�g[�T�\ez�")5��z���׀�e%U��vkkD�=^�"ͮ��Y�+W�hͿ�H��H�Z����K�Qw�ɷ�O�g��a��%��6w�C����SU�A�L_�i6�V~��f�1�]d��'y�׆�0����� 3/��:��� G��f��*�!t\�_�ŋ�� .�W08��c�";Y}�K<��E���1=�)�@,)�{Jq�G��FqcP���o뤙>���!�y G1k/WxQ�S�ҜS�K�0V��z`�1�Tw(�=�B��L��&��2L�KI]M<E�U���>�U� 95K�LI�_��ur���0�\�q�o��T8�a&D��w߰z��9Q��`x}�� ���U�(pBnA�kv�8��V�U���-��
�#9�>2�Jt˷*oy�ni2/�(�&*����$Y3,o1��*6�bQ�XJ�H����� Kh�9@���{(�x�!�l����zn�DDu��%G$���E�D_o���K{���(�r`Y;�T 5��85ԭW�</�_���l�T�T�H�x��+C��mW��9%q���"4:o0[R�>f8�s�mh����JuI�ėi��U�����6X �(�У1�:Nճ����[]D����c=2�5�˿�Ź�Sg6�Pu0�htj���$��.����g��i��}��{�s�0V�s��+���֫ԬbN���){ �1�-��~�OP�0���7{�2�eǪCg*`I}� �e�w�ԂMZD�p+'X1ܪut�~�����D�3�?N��&3�K�b8$�g��w�R�s���������	��eܷ�!�g2�T^9���_�5�Їoe��:���{Ĭ��3�	/��gk˻|_ ���אyi���L��!D��r�ͻ�͵�5�V���� �Ox\��Y3 mF��{�,
��*s-�ąiVc�Kr��G�+FJ��~�T�,t[i��&n��=����(��l��� ��gH�'���'�F߄��� �!��rG~:ѽc���84�q�}��0��Z�����P�W�U59�ĜTB��J��$)Nו6���Xݹ�Fo���'�΀��~d�`��3�!�APc(ITnPy��>޸�F8yu��e\5�\�y]f7�}ģ!���fA*� ��IUO}Ecή��y��ևYPǾ�Oa)Z�b�>Ѓ�R��	��\~�pO��즻u�⊞�ىγ"5�R��+F�k�v$5&�	:���55��16�Z�i�7��(��ƅf�֜�,Δ�C1�1ʷK1�Gٌ�y� z��r��ydG���ٷt�Bw�duH�1��"�M�|��'�Fw����0�m�ʌ]�/Z�x�X��X���8x�R�'lC���V1��
�t�pؙ���m�	����?RC��e�GBW�dY���o�)�����,�vj����ь%�\�7F�k���2 uH�(ᆖ�T�)�J�e�ƹ ۗm7��7�e�0�ǈ߲BՅ[j�3��{�)�.�i��+�"�����츠W����G�7���-�O���������?#
�����D�g-��z��V��y���}"C�ˣs��$`#�.��|77,(>$��M?�!��y ��[t������'k�P
�dZŬE��M-M2���+䫨2�ld��j�0���01��(2+��׻���j&w���mL����5���޳ķ+��o�t�/���8s@��	<bi%,`>�|=��+-I���$Ġ9���0�>J��n;nX��,���s>��)2y��UNX%�;��,�6d�=�s睅B��n���q�e�������>FU�{��iP
f��;�J	T���G6���Yt�r@�vA|���Ō�`t�wJd2�B�1,�2"&3��̧��N�*�@ͪe�M5��Lhෘ�&[ܝ�ZYhB�B������,FSw����
�׌����M�/fuW�X:�Ӎ ��ؤ�q���3ȐR�
9�(?��JL�ȋ���b�������tG#y���ݷ�kZ�4���L�ip`�% ��.L���� H�0�G��z�B�ADگ@|��4p|�����>e$�>mh�m� ��;M	��L�S#����d�	�R�q�+R��kԿ@��tp�`�[A�W��<<i�=�
���v#[�kdV�]��j�Vi���A�G��x��Y��N+V���N[�+��:e�u�dJ�z�#K������-4�Ȫ'?����W�0�k���	o2�ۍ��d����\?�v��t�r�p�'0���"����@n��-�e�
fm�����a�1���{�����5�v��'?��JF�6s���]��B�<�" pF�`'��,-�s��}��~���4}lt�
d	6����,�L($2�%�ell�:���l?t;����W+-�)��3�c0U���t˴�q��H90g��3��zD8���L؏h�A�B�"�)�A($��=ѳ*�G��qz���E���c����{�I��͔�;���~��#q�U�O��*uN孱uy�k	����_}�ǯ�o�������/�N�5F`����-��i�	����Z�>f��9���Ҋ���Lv��c�J�:��Z�����U�؅ ��nUw��.3�%~LFӳ������E+9���)_��%2�~JM�15A�N������^Y>q���^���\	��p�>{-�	�\�U��%:F3���!�`�<��a��5���nJK�����d����g������C���>Q�ڋv�Z��'��Ʋ71�Vi���(���uvH�=d�ͥ5��!0��������&Y��,5�G��z��+o(茘��O�|j֠�_c�*���EƄu�YŌh���jnԤ?&�V�D��.�T�'0P]I�\�X��2Ӟ
Zg�S�E�ug6�Q֐T���<	Iaw��&�64A~h��}9����2��u��-�a�!� �g�W�1��7@��B��;x��ŝ��w�5� �X�~�ց7���Y�9�n!��O��sie�y�[w݈�B�U����X��.�N�16%����0�<�Q��wuSg��N�y���hr�8g7U��Ɵ��I[�Tӕs'PK/Y%JȠWl`_�`����Y57A��*�@]�z�[z=8oc�d}V�2-�-�Z�H£� �-��ʠ��T��.��4ك�7H��]
¤�����ܬ��H���Ɗp��X�S
7`�%��M����� �΁���1���[K��,H�ɭY����;�ֻ�aR�cdo�����SL-��]���� ((���^�6s+d��}eჲ�Z�����3"���� �U �`�=�Ӡ����������tRޣ���<�섥gz���a���EO+D�<K�k�efY��dŝ����,Q�2��uƘ��^��$���$4͒�Q�k��PY�yI|vog�LU�V����� c�);xXR���ʾ���[F�����x�Z_^�7�e0N��!���F����+�=��>b�� �  L,�%B�77$�
Y��|��j������Ǖ��N<A�L�u˩���ߢ ���=h%�dU��ߠO�����d��r+��3y�{�4�%��U�~���|�*�s�~�e�;b}F^�iwzKw��jQ5݉ ��%2��=}����m-�����~��´)�����U��Y�e�.���J��7����dh���
ySsI���;���5�}�]���R�%l��ٿlb�!g��S�t���q;�����
�3��%4=X���U�_S��j�4r;�Aa�fS&J\zn�E+|3T�\����T�7�2;t��-�OY�tNm�+u��cV#�BإbG��N,�xux�h�9�+�4�ɰ��U����@���@r��+lƬx�J�[��~�nZ!JLY�Y��n
��� ˧2��ZfL^��-ҳz��&@���L��vg+7;�]�M��k��@�����7�B�`�Av��ڝ�>�0���}b��w�o�ϸ�����ty�*�Q�"��Ž�I 7I����w�:K.��a.�m�Jj�<���j�xy�
�+���dʊ���i���N��G�sw�[3����P^�WN�#���K\H��ڰ�o����_��y�}�} {L�8� �tV}����@CD3�]=wO��¶�3x)U7t�Q���_�aB�(�8@���w13*wJ8B=�I�j�":��ua�l�iQQ2��*�J�촸��S�C�+���	�-�o����~%9��ղ�|�~�Ν�rW��         �   x���AJAE�ӧ��&=�	x�iM�N�#�:W�����΍ �Z���h�g�}��Y�~}�O���95)�'-ѧ�ƫ�MjУ���6�����{.h�H�L���-�{��\�elؐ9������r�'c���mY�����{K��/,��{Kw�����ʒ�Ŵvד�s?#g�eS��G�K���7�G�߸�����!-_�i��tu�.��MQ��J�v���           x���{a���֋�v��q���+�Z�[pq�!���1�3+s�sB
,�
L�MP�[��LH+⺰�®�U�#�HLA�
##+�
��&���H�[.l�`4U�F`U�`U@�����{�2�k0AҠ�Ԥg$���)���kjh�ũ�(;(Y�V��@ӕ��	S��t�]�9ԣ1y�at�L�M��B��.lU��b���]l���bÅ}@zPp�0��0=�b�|���.l��i��T������̢̜�=... 8�         j   x�K+J+J�4202�54�50W00�#΋�v�(\쿰�b�vq^�a߅]6\�va���pa˅}���/6s�s��4����-��Ґ�X`Qb����� �H4�          H  x��۶B@  �g~�Y���*�H�\�u^̄d�\��읦)��)�j>�^]����V{/��Ъ�Ó�W��p�}�%�<���kh�(-��^�3@�W��+����T�X�ҝ��6q\6}o8sm8��}<�������ێX�� ���@(��;?v�J��w @\3���9!����.ܛ���ٕ�z��[1G�P}T��$�e%?�lsO )��>\6�tus%���kb�c%
u,�H�`�~ׯ���ޡS��WS->)?��5�^���Gd�[�r̾N����k���w5�-�*���;^y�H?��/˲�*�}     