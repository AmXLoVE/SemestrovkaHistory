--
-- PostgreSQL database dump
--

-- Dumped from database version 12.4
-- Dumped by pg_dump version 12.4

-- Started on 2020-12-15 15:02:38

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 202 (class 1259 OID 41106)
-- Name: articles; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.articles (
    name text NOT NULL,
    image text,
    keywords text,
    date_create date NOT NULL,
    id integer NOT NULL,
    article_text text
);


ALTER TABLE public.articles OWNER TO postgres;

--
-- TOC entry 203 (class 1259 OID 41112)
-- Name: articles_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.articles_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.articles_id_seq OWNER TO postgres;

--
-- TOC entry 2854 (class 0 OID 0)
-- Dependencies: 203
-- Name: articles_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.articles_id_seq OWNED BY public.articles.id;


--
-- TOC entry 205 (class 1259 OID 41145)
-- Name: books; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.books (
    name text,
    author text,
    description text,
    write_date date,
    url text NOT NULL
);


ALTER TABLE public.books OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 41139)
-- Name: discussions; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.discussions (
    message_text text,
    message_date timestamp without time zone,
    discussion_id integer,
    person_login text
);


ALTER TABLE public.discussions OWNER TO postgres;

--
-- TOC entry 206 (class 1259 OID 41207)
-- Name: forum; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.forum (
    person_create_login text,
    time_create timestamp without time zone,
    name text,
    description text,
    discussion_id integer NOT NULL
);


ALTER TABLE public.forum OWNER TO postgres;

--
-- TOC entry 208 (class 1259 OID 41219)
-- Name: forum_discussion_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.forum_discussion_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.forum_discussion_id_seq OWNER TO postgres;

--
-- TOC entry 2855 (class 0 OID 0)
-- Dependencies: 208
-- Name: forum_discussion_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.forum_discussion_id_seq OWNED BY public.forum.discussion_id;


--
-- TOC entry 207 (class 1259 OID 41213)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    login text,
    password text,
    selected_articles_id text
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 2710 (class 2604 OID 41114)
-- Name: articles id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.articles ALTER COLUMN id SET DEFAULT nextval('public.articles_id_seq'::regclass);


--
-- TOC entry 2711 (class 2604 OID 41221)
-- Name: forum discussion_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.forum ALTER COLUMN discussion_id SET DEFAULT nextval('public.forum_discussion_id_seq'::regclass);


--
-- TOC entry 2842 (class 0 OID 41106)
-- Dependencies: 202
-- Data for Name: articles; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.articles (name, image, keywords, date_create, id, article_text) FROM stdin;
ТАИНСТВЕННЫЙ РОАНОК: КУДА ИСЧЕЗЛИ ПЕРВЫЕ АНГЛИЙСКИЕ ПОСЕЛЕНЦЫ В АМЕРИКЕ?	/images/2.jpg	Британия;Испания;Мореплавание;тайны	2020-02-12	2	Конец 16 века — период активной колонизации Нового Света. К тому времени испанцы окончательно покорили Ацтекскую империю и закрепили свое влияние в Центральной и Южной Америке. Но восточное побережье Северной Америки оставалось неизведанным. Этим воспользовалась Англия. Набирающая силу страна мореплавателей отправила туда своих первых колонистов. Однако они пропали — как в воду канули. Дважды. Первая экспедиция прибыла на остров Роанок 4 июля 1584 года, чтобы исследовать земли и установить отношения с местным населением — племенами секотан и кроатан. Все прошло успешно. И уже через год в Роанок прибывает сотня людей для начала масштабной колонизации. Их возглавлял друг Рэли — политик и корсар сэр Ричард Гренвилл. Почти сразу новоприбывшие ссорятся с индейцами одного из соседних селений — англичане обвинили их в краже серебряной чаши. Колонисты сжигают поселение вместе с вождем. Так себе начало.
ТОП-5 САМЫХ ВАЖНЫХ СТРАТЕГИЧЕСКИХ БОМБАРДИРОВОК В ИСТОРИИ	/images/3.jpg	авиация;20 век;война;Вторая Мировая	2020-03-05	3	Стратегические бомбардировки направлены на подрыв способности врага вести войну. Они разрушают промышленность, инфраструктуру, боевой дух противника, и нередко прицельно бьют по мирному населению. Под конец 18 века человек впервые поднялся в воздух — на тепловом аэростате братьев Монгольфье. В 1812 году воздушные шары уже использовались французами при осаде Валенсии, а якобинцы сформировали две роты военных воздухоплавателей. Пропитанные лаком аэростаты надувались на месте при помощи специального горна, 90 дней держали водород и, привязанные канатом, парили над войсками для разведки местности. Но для боевых действий эти аппараты подходили плохо: они были игрушками в руках ветра и удачи, поэтому прицельно с аэростатов не бомбили. Настоящую войну с воздуха принесли самолеты и дирижабли в начале 20 века. Пионерами в применении бомбардировщиков стали итальянцы, использовавшие воздушные удары против Османской империи 11 ноября 1911 года в ходе «Ливийской войны». На немецких самолетах «Этрих Таубе» и французских «Блерио» итальянские пилоты сбрасывали ручные гранаты на оазисы Эйн-Зарра и Тангра. Никто не погиб, но турки обвиняли летчиков в атаке на госпиталь. Спустя месяц вместо гранат весом в 1,8 кг начали использовать кустарно изготовленные 10-килограммовые бомбы со шрапнелью и динамитом. Во время Первой мировой войны массированные бомбардировки станут обычным делом. А в начале Второй мировой даже появится откровенный термин terror bombing — «запугивающие бомбардировки». За несколько десятилетий фанерные аэропланы с самодельными бомбами превратятся в армады бомбардировщиков, которые способны стирать с лица земли мегаполисы.
КИЕВУ — ПОЛТОРА ТЫСЯЧЕЛЕТИЯ: ПОЧЕМУ ЭТО СОВЕТСКАЯ ВЫДУМКА?	/images/4.jpg	Киев;10 век;20 век;СССР	2020-03-27	4	Когда тоталитарная система СССР пала, опровержение советских исторических вымыслов приобрело большую популярность. Однако за почти три десятилетия украинской независимости никто из наших государственных деятелей так и не взялся публично пересмотреть легенду о «полуторатысячелетнем Киеве». В 1982 году публика впервые услышала, что Киев основан ровно 1500 лет назад. Сам автор этой гипотезы — российский академик Борис Рыбаков — предостерегал, что дата довольно условная, но магия круглого числа начала действовать. За грохочущими салютами юбилейных торжеств никто не услышал робкие возражения отдельных ученых. Выступить против любимца коммунистической власти академика Рыбакова мало кто рискнул бы. Но в случае с возрастом Киева ситуация осложнялась тем, что найти повод для громкого юбилея столицы УССР было инициативой советской власти. Достойной научной дискуссии тогда не произошло. Вышло смешно: тех ученых, которые периодически осмеливались во времена независимости говорить о ложности советской версии возраста Киева, немедленно начинали клеймить как исторических ренегатов и предателей нации. А факт, что на самом деле именно «гипотеза 1500» была порождением советского официоза, удивительным образом забылся. Впрочем, современные ученые не собираются сдаваться и продолжают открыто бороться с утверждением, что Киеву около 1,5 тысячи лет. Но сколько же тогда на самом деле?
КАК ПРОТИВОСТОЯНИЕ ОЛИГАРХОВ ЧУТЬ НЕ ПОГУБИЛО КАРФАГЕН	/images/5.jpg	Африка;война;Древний Рим	2020-04-12	5	Карфаген — олигархическое государство древности, власть в котором принадлежала родовой финикийской знати. Основным занятием благородных была торговля и угнетение подконтрольных ливийцев, а любимым делом — борьба за власть. О ней они не забывали и во время войн, с еще не вечным, но уже грозным Римом. В 825 году до нашей эры переселенцы с финикийского города Тир основали город Карфаген на средиземноморском берегу Северной Африки. На протяжении 5–3 веков мигранты ввели войны с греками за контроль над торговыми потоками из Финикии, Египта, Малой Азии и Сахары. Финикийцы в итоге победили, город богател и взял под контроль Побережье Северной Африки, Западную часть Сицилии, Южную Испанию, остров Сардинию. Важной статьей доходов Карфагена была торговля металлом и рабами. Рост влияния Карфагена спровоцировал конфликт с еще молодым, но хищным Римом. Римлянам было мало Северной и Центральной Италии, они хотели получить контроль над всем Средиземноморьем и стремились к гегемонии. В результате между Карфагеном и Римом, начиная с 3 века до нашей эры, произойдет серия из войн, названных Пуническими.
ВЕЛИКОЕ КНЯЖЕСТВО ЛИТОВСКОЕ. 200 ЛЕТ НЕИЗВЕСТНОЙ ИСТОРИИ	/images/1.jpg	Великое Княжество Литовское;Литва;14 век	2020-01-15	1	Великое княжество Литовское, Русское и Жемойтское до сих пор остается одним из наименее исследованных периодов украинской истории. Многих удивит тот факт, что большая часть заселенных тогда украинских земель входила в состав этого государства более 200 лет. Среди любителей истории найдется немного знатоков истории ВКЛ. Слабая исследованность привела к появлению стереотипов, мифов и просто выдумок. WAS отвечает на наиболее важные и принципиальные вопросы истории Великого Княжества Литовского. На 13 века большинство племен от Эстонии до польского Поморья находились под властью государств крестоносцев: Ливонского ордена (современные Латвия и Эстония) и Тевтонского ордена (современное Поморье). В планах крестоносцев прибалтийские племена рассматривались исключительно как рабочая сила. Альтернативой могло быть физическое уничтожение непокорных, что и произошло с племенем пруссов. Поводом для захвата этих земель крестоносцами было то, что почти все балтийские племена были язычниками. Перспектива попасть под власть орденов не привлекала группу литовских племен — аукштайты, жемайтов или жмудь, ятвягов и куршей. Они смогли сохранить свою свободу и основать в первой половине 13 века собственное государство — Литовское княжество со столицей в городе Новогрудок. Первым великим князем стал Миндовг, которого 1251 папа Иннокентий IV короновал как христианского короля. 1316 великим князем стал Гедимин, который начал династию Гедиминовичей, потомки которой, включая другими ветвями династии, правивших княжеством до Люблинской унии с Польшей 1569.
\.


--
-- TOC entry 2845 (class 0 OID 41145)
-- Dependencies: 205
-- Data for Name: books; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.books (name, author, description, write_date, url) FROM stdin;
\.


--
-- TOC entry 2844 (class 0 OID 41139)
-- Dependencies: 204
-- Data for Name: discussions; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.discussions (message_text, message_date, discussion_id, person_login) FROM stdin;
\.


--
-- TOC entry 2846 (class 0 OID 41207)
-- Dependencies: 206
-- Data for Name: forum; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.forum (person_create_login, time_create, name, description, discussion_id) FROM stdin;
\.


--
-- TOC entry 2847 (class 0 OID 41213)
-- Dependencies: 207
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (login, password, selected_articles_id) FROM stdin;
\.


--
-- TOC entry 2856 (class 0 OID 0)
-- Dependencies: 203
-- Name: articles_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.articles_id_seq', 5, true);


--
-- TOC entry 2857 (class 0 OID 0)
-- Dependencies: 208
-- Name: forum_discussion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.forum_discussion_id_seq', 1, false);


--
-- TOC entry 2713 (class 2606 OID 41116)
-- Name: articles articles_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.articles
    ADD CONSTRAINT articles_pkey PRIMARY KEY (id);


--
-- TOC entry 2715 (class 2606 OID 41152)
-- Name: books books_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.books
    ADD CONSTRAINT books_pkey PRIMARY KEY (url);


-- Completed on 2020-12-15 15:02:38

--
-- PostgreSQL database dump complete
--

