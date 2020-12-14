--
-- PostgreSQL database dump
--

-- Dumped from database version 12.4
-- Dumped by pg_dump version 12.4

-- Started on 2020-12-09 13:48:33

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
    description text,
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

INSERT INTO public.articles (name, image, description, keywords, date_create, id, article_text) VALUES ('litva', '/images/1.jpg', 'about litva', 'LITVA', '2020-12-01', 5, NULL);
INSERT INTO public.articles (name, image, description, keywords, date_create, id, article_text) VALUES ('russia', '/images/1.jpg', 'about rs', '19 vek', '2020-12-02', 6, NULL);
INSERT INTO public.articles (name, image, description, keywords, date_create, id, article_text) VALUES ('usa', '/images/1.jpg', 'about sa', '20 vek', '2020-12-03', 7, NULL);
INSERT INTO public.articles (name, image, description, keywords, date_create, id, article_text) VALUES ('usa', '/images/1.jpg', 'about us', '22 vek', '2020-12-05', 9, NULL);
INSERT INTO public.articles (name, image, description, keywords, date_create, id, article_text) VALUES ('russia', '/images/1.jpg', 'about ss', '23 vek', '2020-12-06', 10, NULL);
INSERT INTO public.articles (name, image, description, keywords, date_create, id, article_text) VALUES ('usa', '/images/1.jpg', 'about ua', '24 vek', '2020-12-07', 11, NULL);
INSERT INTO public.articles (name, image, description, keywords, date_create, id, article_text) VALUES ('russia', '/images/1.jpg', 'about ia', 'Литва;14 век;Великое княжество Литовское', '2020-12-04', 8, NULL);


--
-- TOC entry 2845 (class 0 OID 41145)
-- Dependencies: 205
-- Data for Name: books; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.books (name, author, description, write_date, url) VALUES ('История России', 'Бахлачев У.У., Нарывкин Ю.Ю.', '', '2020-09-12', '/pdf/246_2-istorija-rossii_-10kl_-baz_-ur_-v-2ch_-ch_2_levandovskij-a_a_2015-256s.pdf');
INSERT INTO public.books (name, author, description, write_date, url) VALUES ('История Татарстана', 'Бахлачев У.У., Нарывкин Ю.Ю.', '', '2020-09-12', 'Файл отсутствует');


--
-- TOC entry 2844 (class 0 OID 41139)
-- Dependencies: 204
-- Data for Name: discussions; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('эй хуй
', '2020-12-07 15:43:00', 12, 'frfrf');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('123', '2020-12-07 16:07:00', 17, 'frfrf');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('123', '2020-12-07 16:07:00', 18, 'frfrf');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('434', '2020-12-07 17:35:00', 17, 'ffr');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('ака', '2020-12-07 17:37:00', 17, 'ffr');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('adadad', '2020-12-08 22:40:00', 17, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('4545', '2020-12-08 22:49:00', 17, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('фвфвф', '2020-12-08 22:52:00', 19, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('апкпкп', '2020-12-08 22:52:00', 19, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('№№№№№№№', '2020-12-08 22:54:00', 19, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('########', '2020-12-08 22:54:00', 19, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('ghbdtn!,./)(*&^%$#@!)(*?:%;№"!
', '2020-12-08 22:54:00', 19, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('ффффффффф', '2020-12-08 22:54:00', 17, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('а
а
а
а
а
а
а
а
а
а
а
а

а', '2020-12-08 22:55:00', 17, 'fff');
INSERT INTO public.discussions (message_text, message_date, discussion_id, person_login) VALUES ('как же так?
спросите вы.
', '2020-12-08 22:55:00', 17, 'fff');


--
-- TOC entry 2846 (class 0 OID 41207)
-- Dependencies: 206
-- Data for Name: forum; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.forum (person_create_login, time_create, name, description, discussion_id) VALUES ('frfrf', '2020-12-07 00:00:00', 'эй, ямщик', 'покажи ка дорогу', 17);
INSERT INTO public.forum (person_create_login, time_create, name, description, discussion_id) VALUES ('frfrf', '2020-12-07 00:00:00', '123', '123', 18);
INSERT INTO public.forum (person_create_login, time_create, name, description, discussion_id) VALUES ('fff', '2020-12-08 00:00:00', '123', '123', 19);


--
-- TOC entry 2847 (class 0 OID 41213)
-- Dependencies: 207
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.users (login, password, selected_articles_id) VALUES ('fff', 'dwxxX5p1f7P8F4SfOZEpRdUJTEnV+cx8A8pwsj+k++vgybe9MumvavGEYclKYJookaj9oRXYuN+G89otdfRcwsmVaHEb9IDLkzxmNxesPb+icAzreLN1YqttGLypGL6F7TTuur5DC7KUrslI8ITlLQc/SG9bbWjGehiCsco5zEc=599940', '');


--
-- TOC entry 2856 (class 0 OID 0)
-- Dependencies: 203
-- Name: articles_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.articles_id_seq', 11, true);


--
-- TOC entry 2857 (class 0 OID 0)
-- Dependencies: 208
-- Name: forum_discussion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.forum_discussion_id_seq', 19, true);


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


-- Completed on 2020-12-09 13:48:33

--
-- PostgreSQL database dump complete
--

