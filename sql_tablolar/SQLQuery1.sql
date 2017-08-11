 CREATE TABLE [ucretler] (
  [ID] INT,
  [misafirID] int,
  [fiyatID] int,
  [yetki] int,
  PRIMARY KEY ([ID])
);

CREATE TABLE [menuler] (
  [ID] int,
  [ad] nvarchar(30),
  [link] nvarchar(30),
  [yetki] int,
  PRIMARY KEY ([ID])
);

CREATE TABLE [ilceler] (
  [ID] int,
  [ilceAdi] int,
  PRIMARY KEY ([ID])
);

CREATE INDEX [FK,PK] ON  [ilceler] ([ID]);

CREATE TABLE [adres] (
  [ID] int,
  [misafirID] int,
  [ilID] int,
  [ilceID] int,
  [adres] nvarchar(250),
  PRIMARY KEY ([ID])
);

CREATE INDEX [FK] ON  [adres] ([misafirID], [ilID], [ilceID]);

CREATE TABLE [misafirler] (
  [ID] int,
  [tc] int,
  [ad] nvarchar(30),
  [soyad] nvarchar(30),
  [telefon] int,
  [odaID] int,
  [adresID] int,
  [gorevID] int,
  [yetki] int,
  PRIMARY KEY ([ID])
);

CREATE TABLE [rezervasyon_kayit] (
  [ID] int,
  [odaID] int,
  [rezerID] int,
  PRIMARY KEY ([ID])
);

CREATE TABLE [kalinanodalar] (
  [ID] int,
  [misafirID] int,
  [odaID] int,
  [gelistarih] datetime,
  [cikistarih] datetime,
  PRIMARY KEY ([ID])
);

CREATE INDEX [FK] ON  [kalinanodalar] ([misafirID], [odaID]);

CREATE TABLE [fatura] (
  [ID] int,
  [misafirID] int,
  [ucretID] int,
  [yetki] int,
  PRIMARY KEY ([ID])
);

CREATE TABLE [guncel_kayit] (
  [ID] int,
  [misafirID] int,
  [telefon] int,
  PRIMARY KEY ([ID])
);

CREATE INDEX [FK] ON  [guncel_kayit] ([misafirID], [telefon]);

CREATE TABLE [gorevler] (
  [ID] int,
  [gorevadi] nvarchar(30),
  PRIMARY KEY ([ID])
);

CREATE INDEX [FK] ON  [gorevler] ([gorevadi]);

CREATE TABLE [odalar] (
  [ID] int,
  [odanum] int,
  [odatip] nvarchar(10),
  [maxkisi] int,
  [aciklama] nvarchar(200),
  [yetki] int,
  PRIMARY KEY ([ID])
);

CREATE TABLE [personel] (
  [ID] int,
  [ad] nvarchar(30),
  [soyad] nvarchar(30),
  [telefon] int,
  [yetki] int,
  PRIMARY KEY ([ID])
);

CREATE TABLE [iller] (
  [ID] int,
  [ilAdi] nvarchar(40)
);

CREATE INDEX [FK,PK] ON  [iller] ([ID]);

CREATE TABLE [rezervasyon_kisi] (
  [ID] int,
  [ad] nvarchar(30),
  [soyad] nvarchar(30),
  [telefon] int,
  [Unvan] nvarchar(30),
  [email] nvarchar(30),
  [tarih] datetime,
  PRIMARY KEY ([ID])
);

