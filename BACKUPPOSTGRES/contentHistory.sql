--
-- PostgreSQL database dump
--

-- Dumped from database version 12.4
-- Dumped by pg_dump version 12.4

-- Started on 2020-12-15 23:56:38

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
-- TOC entry 202 (class 1259 OID 65988)
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
-- TOC entry 203 (class 1259 OID 65994)
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
-- TOC entry 204 (class 1259 OID 65996)
-- Name: books; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.books (
    name text,
    author text,
    url text NOT NULL,
    write_date integer
);


ALTER TABLE public.books OWNER TO postgres;

--
-- TOC entry 205 (class 1259 OID 66002)
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
-- TOC entry 206 (class 1259 OID 66008)
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
-- TOC entry 207 (class 1259 OID 66014)
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
-- Dependencies: 207
-- Name: forum_discussion_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.forum_discussion_id_seq OWNED BY public.forum.discussion_id;


--
-- TOC entry 208 (class 1259 OID 66016)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    login text,
    password text,
    selected_articles_id text
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 2710 (class 2604 OID 66022)
-- Name: articles id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.articles ALTER COLUMN id SET DEFAULT nextval('public.articles_id_seq'::regclass);


--
-- TOC entry 2711 (class 2604 OID 66023)
-- Name: forum discussion_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.forum ALTER COLUMN discussion_id SET DEFAULT nextval('public.forum_discussion_id_seq'::regclass);


--
-- TOC entry 2842 (class 0 OID 65988)
-- Dependencies: 202
-- Data for Name: articles; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.articles VALUES ('ТАИНСТВЕННЫЙ РОАНОК: КУДА ИСЧЕЗЛИ ПЕРВЫЕ АНГЛИЙСКИЕ ПОСЕЛЕНЦЫ В АМЕРИКЕ?', '/images/2.jpg', 'Британия;Испания;Мореплавание;тайны', '2020-02-12', 2, 'Конец 16 века — период активной колонизации Нового Света. К тому времени испанцы окончательно покорили Ацтекскую империю и закрепили свое влияние в Центральной и Южной Америке. Но восточное побережье Северной Америки оставалось неизведанным. Этим воспользовалась Англия. Набирающая силу страна мореплавателей отправила туда своих первых колонистов. Однако они пропали — как в воду канули. Дважды. Первая экспедиция прибыла на остров Роанок 4 июля 1584 года, чтобы исследовать земли и установить отношения с местным населением — племенами секотан и кроатан. Все прошло успешно. И уже через год в Роанок прибывает сотня людей для начала масштабной колонизации. Их возглавлял друг Рэли — политик и корсар сэр Ричард Гренвилл. Почти сразу новоприбывшие ссорятся с индейцами одного из соседних селений — англичане обвинили их в краже серебряной чаши. Колонисты сжигают поселение вместе с вождем. Так себе начало.');
INSERT INTO public.articles VALUES ('ТОП-5 САМЫХ ВАЖНЫХ СТРАТЕГИЧЕСКИХ БОМБАРДИРОВОК В ИСТОРИИ', '/images/3.jpg', 'авиация;20 век;война;Вторая Мировая', '2020-03-05', 3, 'Стратегические бомбардировки направлены на подрыв способности врага вести войну. Они разрушают промышленность, инфраструктуру, боевой дух противника, и нередко прицельно бьют по мирному населению. Под конец 18 века человек впервые поднялся в воздух — на тепловом аэростате братьев Монгольфье. В 1812 году воздушные шары уже использовались французами при осаде Валенсии, а якобинцы сформировали две роты военных воздухоплавателей. Пропитанные лаком аэростаты надувались на месте при помощи специального горна, 90 дней держали водород и, привязанные канатом, парили над войсками для разведки местности. Но для боевых действий эти аппараты подходили плохо: они были игрушками в руках ветра и удачи, поэтому прицельно с аэростатов не бомбили. Настоящую войну с воздуха принесли самолеты и дирижабли в начале 20 века. Пионерами в применении бомбардировщиков стали итальянцы, использовавшие воздушные удары против Османской империи 11 ноября 1911 года в ходе «Ливийской войны». На немецких самолетах «Этрих Таубе» и французских «Блерио» итальянские пилоты сбрасывали ручные гранаты на оазисы Эйн-Зарра и Тангра. Никто не погиб, но турки обвиняли летчиков в атаке на госпиталь. Спустя месяц вместо гранат весом в 1,8 кг начали использовать кустарно изготовленные 10-килограммовые бомбы со шрапнелью и динамитом. Во время Первой мировой войны массированные бомбардировки станут обычным делом. А в начале Второй мировой даже появится откровенный термин terror bombing — «запугивающие бомбардировки». За несколько десятилетий фанерные аэропланы с самодельными бомбами превратятся в армады бомбардировщиков, которые способны стирать с лица земли мегаполисы.');
INSERT INTO public.articles VALUES ('КИЕВУ — ПОЛТОРА ТЫСЯЧЕЛЕТИЯ: ПОЧЕМУ ЭТО СОВЕТСКАЯ ВЫДУМКА?', '/images/4.jpg', 'Киев;10 век;20 век;СССР', '2020-03-27', 4, 'Когда тоталитарная система СССР пала, опровержение советских исторических вымыслов приобрело большую популярность. Однако за почти три десятилетия украинской независимости никто из наших государственных деятелей так и не взялся публично пересмотреть легенду о «полуторатысячелетнем Киеве». В 1982 году публика впервые услышала, что Киев основан ровно 1500 лет назад. Сам автор этой гипотезы — российский академик Борис Рыбаков — предостерегал, что дата довольно условная, но магия круглого числа начала действовать. За грохочущими салютами юбилейных торжеств никто не услышал робкие возражения отдельных ученых. Выступить против любимца коммунистической власти академика Рыбакова мало кто рискнул бы. Но в случае с возрастом Киева ситуация осложнялась тем, что найти повод для громкого юбилея столицы УССР было инициативой советской власти. Достойной научной дискуссии тогда не произошло. Вышло смешно: тех ученых, которые периодически осмеливались во времена независимости говорить о ложности советской версии возраста Киева, немедленно начинали клеймить как исторических ренегатов и предателей нации. А факт, что на самом деле именно «гипотеза 1500» была порождением советского официоза, удивительным образом забылся. Впрочем, современные ученые не собираются сдаваться и продолжают открыто бороться с утверждением, что Киеву около 1,5 тысячи лет. Но сколько же тогда на самом деле?');
INSERT INTO public.articles VALUES ('КАК ПРОТИВОСТОЯНИЕ ОЛИГАРХОВ ЧУТЬ НЕ ПОГУБИЛО КАРФАГЕН', '/images/5.jpg', 'Африка;война;Древний Рим', '2020-04-12', 5, 'Карфаген — олигархическое государство древности, власть в котором принадлежала родовой финикийской знати. Основным занятием благородных была торговля и угнетение подконтрольных ливийцев, а любимым делом — борьба за власть. О ней они не забывали и во время войн, с еще не вечным, но уже грозным Римом. В 825 году до нашей эры переселенцы с финикийского города Тир основали город Карфаген на средиземноморском берегу Северной Африки. На протяжении 5–3 веков мигранты ввели войны с греками за контроль над торговыми потоками из Финикии, Египта, Малой Азии и Сахары. Финикийцы в итоге победили, город богател и взял под контроль Побережье Северной Африки, Западную часть Сицилии, Южную Испанию, остров Сардинию. Важной статьей доходов Карфагена была торговля металлом и рабами. Рост влияния Карфагена спровоцировал конфликт с еще молодым, но хищным Римом. Римлянам было мало Северной и Центральной Италии, они хотели получить контроль над всем Средиземноморьем и стремились к гегемонии. В результате между Карфагеном и Римом, начиная с 3 века до нашей эры, произойдет серия из войн, названных Пуническими.');
INSERT INTO public.articles VALUES ('ВЕЛИКОЕ КНЯЖЕСТВО ЛИТОВСКОЕ. 200 ЛЕТ НЕИЗВЕСТНОЙ ИСТОРИИ', '/images/1.jpg', 'Великое Княжество Литовское;Литва;14 век', '2020-01-15', 1, 'Великое княжество Литовское, Русское и Жемойтское до сих пор остается одним из наименее исследованных периодов украинской истории. Многих удивит тот факт, что большая часть заселенных тогда украинских земель входила в состав этого государства более 200 лет. Среди любителей истории найдется немного знатоков истории ВКЛ. Слабая исследованность привела к появлению стереотипов, мифов и просто выдумок. WAS отвечает на наиболее важные и принципиальные вопросы истории Великого Княжества Литовского. На 13 века большинство племен от Эстонии до польского Поморья находились под властью государств крестоносцев: Ливонского ордена (современные Латвия и Эстония) и Тевтонского ордена (современное Поморье). В планах крестоносцев прибалтийские племена рассматривались исключительно как рабочая сила. Альтернативой могло быть физическое уничтожение непокорных, что и произошло с племенем пруссов. Поводом для захвата этих земель крестоносцами было то, что почти все балтийские племена были язычниками. Перспектива попасть под власть орденов не привлекала группу литовских племен — аукштайты, жемайтов или жмудь, ятвягов и куршей. Они смогли сохранить свою свободу и основать в первой половине 13 века собственное государство — Литовское княжество со столицей в городе Новогрудок. Первым великим князем стал Миндовг, которого 1251 папа Иннокентий IV короновал как христианского короля. 1316 великим князем стал Гедимин, который начал династию Гедиминовичей, потомки которой, включая другими ветвями династии, правивших княжеством до Люблинской унии с Польшей 1569.');
INSERT INTO public.articles VALUES ('КОЗАКИ-РАБОТОРГОВЦЫ. КАК ХМЕЛЬНИЦКИЙ УКРАИНЦАМИ ТОРГОВАЛ', '/images/6.jpg', 'козаки;война;Крым;Османская Империя', '2020-06-19', 6, 'Козацко-польская война 1648–1657 годов обернулась катастрофой для украинского населения. Люди страдали не только от баталий, репрессий, голода и болезней — десятки тысяч их гнали в плен в Крым. Это делалось с молчаливого согласия козаков, а иногда — даже при их участии. Образ гетмана Богдана Хмельницкого в украинском фольклоре далеко не всегда положительный. На протяжении 19 века этнографы с историками собрали в различных регионах Украины несколько вариантов, возможно, самой интересной песни о нем. «Хмельницкий тот был такой, что с турком знался. Поедет бывало к турку да и продаст один, другой город или село. Турки уже те села разоряли и ясырь брали». Первые исследователи связывали эту песню с событиями после козацко-татарской осады польских войск под Жванцем на Подолье в конце 1653 года. Тогда крымский хан Ислам III Герей, неожиданно для козаков замирившись с польским королем Яном II Казимиром, получил от него право собрать ясырь на украинских землях. Десятки тысяч простолюдинов вывели в Крым. А народные проклятия Хмельницкому якобы были вызваны просто развязыванием войны и союзом с крымцами. Но сегодня мы знаем, что за подобными песнями стояла более страшная история.');
INSERT INTO public.articles VALUES ('ДЕЛО КНЯЗЕЙ. КТО ЗАРЕЗАЛ СЫНОВЕЙ ВЛАДИМИРА ВЕЛИКОГО?', '/images/7.jpg', '11 век;Русь;тайны', '2020-07-01', 7, 'Летом 1015 года умер киевский князь Владимир, и подспудная борьба за его наследство стала кровавой. По пути на похороны отца убиты младшие сыновья «от болгарыни» — Борис и Глеб. В том же году при загадочных обстоятельствах погиб сын «от грекини» Святослав. Князь Владимир был похотлив — точное число его детей неизвестно. Дочерей никто тогда не считал, сыновей было вроде бы 13, но как минимум трое умерли раньше отца. Главными действующими лицами первого этапа междоусобицы стали Ярослав (будущий «Мудрый») и Святополк (будущий «Окаянный). Эти двое князей оставили другим Владимировичам роли жертв или наблюдателей и обоснованно подозреваются в организации братоубийства. Посмотрим в их досье. «Повесть временных лет» прямо называет имя заказчика убийств Бориса, Глеба и Святослава. Якобы взяв Киев, Святополк отправил Борису послание: «Брат, хочу жить с тобой в любви и к полученному от отца владению добавлю еще». Тот признает новую власть и едет для встречи в столицу, но «ведомый каиновыми мыслями» Святополк все равно посылает убийц. При чем, судя по сумбурному описанию летописца, посылает два раза. Во время первого покушения Бориса ранят, а его слуге рубят голову ради нашейного украшения из золота. Неудавшееся покушение доводят до конца наемные викинги. Запомним эту важную деталь.');
INSERT INTO public.articles VALUES ('КАК ГОМИНИД ВЫБИЛСЯ В ЛЮДИ: ОСНОВНЫЕ ТЕОРИИ АНТРОПОГЕНЕЗА', '/images/8.jpg', 'археология;Древний Мир;каменный век', '2020-08-20', 8, 'За последние 10 тысяч лет сформировалась близкая нам человеческая культура. Племенные группы охотников и собирателей развились до первых земледельческих обществ, что привело к появлению городов и государств. Род Homo шел к этому миллионы лет, но что же нами двигало все это время? Есть о чем поспорить. Раскапывая древние захоронения на рубеже 50–130 тысяч лет назад мы видим одну и ту же картину. Постепенное появление типовых орудий труда из кости и камня: скребков, зазубренных гарпунов, ножей и шил — унификация от стоянок в Грузии до пещер ЮАР. Похоронные обряды с подношениями в виде зерен и охры, украшения из раковин, скорлупы яиц, трещотки и свирели из костей птиц. Первое искусство — например потрясающие наскальные рисунки диких лошадей из пещеры Шове и примитивные статуэтки «Венер палеолита». Все то, что делает гоминид Человеком разумным. Одни антропологи называют это «эволюционным взрывом», другие «большим скачком». А вот что именно запустило эволюцию и превратило нас в доминирующий вид на планете — ответ однозначным не будет. Первые гоминиды вели древесный образ жизни. Но примерно 7 миллионов лет назад их ареал обитания в районе нынешнего Чада или Кении стал превращаться из лесов в саванну. Деревьев становилось меньше, некоторые гоминиды вымерли, некоторые — откочевали в густые леса тропиков. Но были и те, кто начал вести наземный образ жизни. Руки, приспособленные для хватания веток и прыжков по деревьям, начали совершать рутинную работу на земле и отмелях — лущение зерен, сбор раковин и моллюсков, рытье корнеплодов. Понадобилось более 4 миллионов лет чтобы появился первый представитель рода Homo — Человек умелый. Его мозг весил 650 грамм, рост составлял до 1,4 метра, а ступня была уже похожа на нашу — большой палец не отведен в сторону, как у австралопитеков, а расположен в одном ряду с другими фалангами. Так ходить на своих двоих было гораздо удобней. Умелый человек пользовался кварцевыми рубилами, которые приносил к местам кочевок за 50 километров. Мелкая моторика развивала его мозговые клетки, он употреблял больше белка из разбитых камнями костей животных и срезанных частей туш — отсюда и силы сходить за десятки километров к жерлу потухшего вулкана за обсидианом или кочующими животными. Все это на фоне сильных колебаний климата увеличивало мозг, заставляя гоминид запоминать большие массивы информации и оперировать абстрактными идеями для выживания.');
INSERT INTO public.articles VALUES ('НАШИ ДРУЗЬЯ В СТАМБУЛЕ: КАК ХМЕЛЬНИЦКИЙ ИСКАЛ СОЮЗА С ЯНЫЧАРСКОЙ ХУНТОЙ', '/images/9.jpg', 'Османская Империя;козаки;война;Турция', '2020-09-30', 9, 'После начала войны с поляками гетман Хмельницкий имел расположение османской власти. Его дипломатические успехи зависели от личных связей. Янычарская клика, захватившая власть в Стамбуле, лоббировала козацкие интересы. В августе 1648 года Стамбул всколыхнул мятеж. Османские богословы-юристы вместе с янычарами свергли с престола султана Ибрагима І, которого тогдашний шейх уль-ислам объявил сумасшедшим. Мать Ибрагима — властолюбивый гречанка Кёсем-султан — лично закрыла сына в дворце Топкапы. Вскоре его задушили. Разъяренные янычары казнили и великого визиря Ахмеда-пашу, после чего разорвали тело на части. Одна из стамбульских хроник утверждает, что народ покупал куски как лекарства от ревматизма. Замученного чиновника запомнили под персидским прозвищем «Гезар-паре» — «тысяча кусков». Причина мятежа — непомерные расходы султана, который купался в роскоши, и увеличение налогов на фоне Критской войны. В это время открывать еще один фронт было немыслимо. Однако это отнюдь не мешало покровительствовать соседям, которые просились в подданство. К примеру, козакам.');
INSERT INTO public.articles VALUES ('ХОЧЕШЬ ПОБЕДИТЬ БРИТАНСКУЮ ИМПЕРИЮ? СПРОСИ У МАОРИ КАК', '/images/10.jpg', 'Британия;война;Новая Зеландия;чукчи;традиции', '2020-10-14', 10, 'Картошка, древние разболтанные мушкеты и копченые головы пленных для психологической войны. Благодаря военному мастерству и грамотному использованию европейских товаров, новозеландские маори избежали судьбы индейцев. Со времени прибытия европейцев на островах Новой Зеландии случилось более 3000 боев, стычек и набегов с участием коренных жителей. Важнейшие из них вошли в историю как Мушкетные и Земельные войны. Их результатом стал уникальный для колониальной истории договор — маори получили равные права с подданными британской короны. Маори — потомки отчаянных мореплавателей, около 1200 года нашей эры заселивших Новую Зеландию, острова Чатем и Кука. Мускулистые статные гребцы несколькими волнами прибывали из Восточной Полинезии. Чтобы управлять 30-метровыми каноэ вака с сотней человек на борту, бороться с непогодой и добывать пропитание в открытом океане, требуется мужество и еще больше — дисциплина. Рядовые члены племени беспрекословно подчинялись вождям, капитанам и рулевым. Жизнь маори определяло понятие мана – это одновременно и слава бойца, и его положение в социуме, и духовная сила. Чтобы стать взрослым, мальчик должен был пройти болезненную инициацию — вытерпеть первую татуировку долотом на лице. Признанный мужчиной, он сильнее всего боялся проявить трусость. Потерять ману – для маори хуже смерти. Скрыть эпизод малодушия было невозможно. Лицевая татуировка та-моко рассказывала о владельце все: от навыков в ремеслах до поведения на поле боя. Племена Новой Зеландии постоянно воевали, и война диктовала им традиции. Среди них ритуальный каннибализм на поле боя, дуэль на тайаха, многолетняя кровная месть за гибель родственника — уту, муру — обязательный поход на противника в случае смерти вождя дружественного племени, хоть бы и естественной. Отрубленные головы врагов пропитывали жиром акульей печени, варили на пару или коптили, потом сушили. Эти трофеи, мокомокаи, выставлялись в священных местах, провоцировали войны и завершали их – перед заключением мира надо было обменяться головами.');


--
-- TOC entry 2844 (class 0 OID 65996)
-- Dependencies: 204
-- Data for Name: books; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.books VALUES ('История России 10 класс, часть 2', 'А.А. Левандовский', '/pdf/История_России_10_класс.pdf', 2015);
INSERT INTO public.books VALUES ('История России XX век, курс лекций', 'О.О. Антропов, И.А. Белоконь, С.И. Голотик', '/pdf/История_России_20_век.pdf', 2010);
INSERT INTO public.books VALUES ('История Древней Кореи', 'В.Н. Лимарев', '/pdf/История_Древней_Кореи.pdf', 2018);


--
-- TOC entry 2845 (class 0 OID 66002)
-- Dependencies: 205
-- Data for Name: discussions; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.discussions VALUES ('Да, ещё стоит добавить, что они декабристы', '2020-12-15 23:40:00', 3, 'Login');
INSERT INTO public.discussions VALUES ('Полностью с вами согласна!', '2020-12-15 23:47:00', 3, 'Masha');
INSERT INTO public.discussions VALUES ('О боже...', '2020-12-15 23:51:00', 5, 'Sasha');
INSERT INTO public.discussions VALUES ('Да кто угодно', '2020-12-15 23:51:00', 4, 'Sasha');
INSERT INTO public.discussions VALUES ('Это люди', '2020-12-15 23:52:00', 3, 'Sasha');


--
-- TOC entry 2846 (class 0 OID 66008)
-- Dependencies: 206
-- Data for Name: forum; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.forum VALUES ('Login', '2020-12-15 00:00:00', 'Кто такие декабристы? Герои или враги?', 'Декабристы декабристы декабристы декабристы. Я считаю, что декабристы декабристы. Что вы думаете по этому поводу?', 3);
INSERT INTO public.forum VALUES ('Login', '2020-12-15 00:00:00', 'Кто, если не Путин?', 'А что, если бы Путин не стал президентом. Мир бы разрушился. ', 4);
INSERT INTO public.forum VALUES ('Masha', '2020-12-15 00:00:00', 'Вторая Мировая война ещё не закончилась?', 'Война война война война! Война война? Но война война, а война война война. Возможно война война война. Война война война. Война?', 5);


--
-- TOC entry 2848 (class 0 OID 66016)
-- Dependencies: 208
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.users VALUES ('Login', 'zl0vhceAuPQld2p1T9cnod1mPsNpZOUY0iE3D3SHYxJgJOdkbzE0ERBkuC2Qwk9F24HMr5aw/AqXMMWiaRpA1d6mm0dS+yvDsSbRaFqk37tPXEKmFLHMaVN0PkSzfmyYB7hZjif8QAABq/ro4FW+oGUJLHsM/7m5qDoiw9McwJY=948172', '1,');
INSERT INTO public.users VALUES ('Masha', 'NhWlc+SgsG9D1005y0inLCO/6PmG1kZIVFWZEavgAtv5PlD104KURXim76MVrANBVCoBIKPpiQh3lDJoEN8Dnz+eriP3Qqs99sQK/DZiB/Gffg1jsm1wElyWdcPCP1V5uxX1s5ufpcaihLnG/B4+lzNPYtgnLl8jCHm4aqxDysM=565139', NULL);
INSERT INTO public.users VALUES ('Sasha', 'iT1pHRrEoveppdv3CKWZbi/ApAr8dr7joJpQo1BbmNgt9EhfPoLdQZtaj8yHhM1plt2q1IaFBazN53ToDSLcEgLZyAMObquMHniH5m4UqTdXqvf9M9f9D0lirUgWNG+oREn+w1UkltkqfG9Und2I31ASYf0Xt/Aj6x0tnHcul/I=555711', NULL);


--
-- TOC entry 2856 (class 0 OID 0)
-- Dependencies: 203
-- Name: articles_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.articles_id_seq', 10, true);


--
-- TOC entry 2857 (class 0 OID 0)
-- Dependencies: 207
-- Name: forum_discussion_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.forum_discussion_id_seq', 5, true);


--
-- TOC entry 2713 (class 2606 OID 66025)
-- Name: articles articles_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.articles
    ADD CONSTRAINT articles_pkey PRIMARY KEY (id);


--
-- TOC entry 2715 (class 2606 OID 66027)
-- Name: books books_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.books
    ADD CONSTRAINT books_pkey PRIMARY KEY (url);


-- Completed on 2020-12-15 23:56:39

--
-- PostgreSQL database dump complete
--

