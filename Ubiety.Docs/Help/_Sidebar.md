- [Welcome to the [TODO: Add project name]](8497c358-23f2-43cc-a4be-539ac07e5e53)
- [Version History](328c00ce-887a-4a0a-9317-e1129554ce7b)
  - [Version 1.0.0.0](cdb66a1a-1c19-47b8-9114-13e1dc2c32fd)
- [Ubiety Namespace](6914e263-4eb2-ee9a-b0e6-9e93cef96d47)
  - [Xmpp Class](e953c009-389e-9c73-f5e2-3a498af966ca)
    - [Xmpp Constructor](28272e9f-7dc2-5c6b-bae6-7f500d52567e)
    - [Xmpp Properties](dcdc9928-827b-1202-7306-8af5a1f8894d)
      - [Xmpp.Connected Property](205eb7cc-8255-fbfa-d237-d829cb3af4b9)
      - [Xmpp.Settings Property](520078c7-4449-c641-f7b6-a88230d5d648)
    - [Xmpp Methods](e50aee6c-3a19-fa4d-8e5a-8f07ece2c74f)
      - [Xmpp.Connect Method](6b6171f5-2bee-1504-96ec-20ac4781324c)
      - [Xmpp.Disconnect Method](eaa8db52-081b-ca1b-705a-00fb1d2ec327)
      - [Xmpp.Send Method](63c965d0-f266-9dc8-f670-7b3612373154)
        - [Xmpp.Send Method (Tag)](d60e0216-0deb-feea-b8b2-25e027e1fe19)
        - [Xmpp.Send Method (TagEventArgs)](2dab9862-9a85-6085-bef2-04eb8ae5312c)
    - [Xmpp Events](6d966cb9-be14-968f-e5ce-77e343dcba75)
      - [Xmpp.OnError Event](c8ee8878-f873-4eb7-57dc-b760cf88959f)
      - [Xmpp.OnNewTag Event](f7d590a1-4e93-cf79-b297-bdc538eedb0f)
    - [Xmpp Fields](273089cb-c770-fed9-b3c7-54f590497f07)
      - [Xmpp.Version Field](d66415bd-83ac-4af3-27f6-2937c3a10dbf)
- [Ubiety.Common Namespace](3a988b7f-7a78-d824-53e6-d57463519974)
  - [ErrorSeverity Enumeration](069e8a4c-9425-b097-52f5-247327fda0f9)
  - [ErrorType Enumeration](a7fe2264-b531-3d6d-7827-1567e3d65dd9)
  - [ICompression Interface](f6f8c0c1-c8ba-0ebd-7de4-6481edf74d1c)
    - [ICompression Methods](4b037988-a094-9d9d-38a0-170d2254bc1c)
      - [ICompression.Deflate Method](7f031f0a-db60-108e-f56d-305c30f6ae65)
      - [ICompression.Inflate Method](0829f33d-8142-520f-15df-765de8e90b5e)
  - [JID Structure](a42ab0f9-c244-fec1-e6d6-a22cc63529da)
    - [JID Constructor](535bc30e-c4fd-9f8d-a0ab-d39862fdfe17)
      - [JID Constructor (String)](a8261379-4317-0b34-7c45-f3760b9c8660)
      - [JID Constructor (String, String, String)](4646f067-d7ad-8d1e-386f-aadb761ac999)
    - [JID Properties](5bd794fd-c062-8750-4754-35228dff698d)
      - [JID.Resource Property](33783470-79dc-7901-e1cd-97f25a910aee)
      - [JID.Server Property](b9cf6535-a0dd-4fe5-8162-6e7bad297ab8)
      - [JID.User Property](72796f1e-a043-e35b-fec4-a896301d3376)
    - [JID Methods](8532448a-bfdf-66cb-dda7-e1fc7ebe1533)
      - [JID.Equals Method](2cbedc01-431a-ef76-ea06-12a5566dbc94)
        - [JID.Equals Method (Object)](07acbcaf-a25f-4cda-bc10-440c0529130b)
        - [JID.Equals Method (JID)](af2bf8d7-b015-8827-3e2b-0a97a740141f)
      - [JID.GetHashCode Method](f8b42293-6c06-7be4-1a2c-f9b69bbccbf4)
      - [JID.ToString Method](a3c375aa-23ae-7064-63ad-c13ececa1e14)
    - [JID Operators and Type Conversions](b92440b6-cdae-2978-4a6b-8113a29de9a7)
      - [JID.Equality Operator](c7635c13-ee94-b884-6d0a-7145e73dc8ec)
      - [JID Implicit Conversion Operators](060f2589-f878-7855-d198-4d4d542ea3b5)
        - [JID Implicit Conversion (String to JID)](168c1286-1212-3c70-ef6c-cc0e5d759897)
        - [JID Implicit Conversion (JID to String)](90039421-1f16-72cd-47ea-2e93eebf33a9)
      - [JID.Inequality Operator](680892c7-fa27-702e-3eb4-4abd16c0d929)
  - [Namespaces Class](b57934f7-bc68-e177-b57b-1a9dfbcd62d7)
    - [Namespaces Fields](732c654c-2607-08d8-0ae3-b78ebfb41fac)
      - [Namespaces.Auth Field](a42c3155-14e6-9501-18bd-f29d2d4cc436)
      - [Namespaces.Bind Field](ee144efe-921e-7e6a-e760-3c27a8efa88e)
      - [Namespaces.Client Field](ac273cb4-526f-6072-dbd7-d2024af95b46)
      - [Namespaces.ClientState Field](d68e39b1-7d72-2ce1-8603-00a0815443bd)
      - [Namespaces.Compression Field](661467a2-d7ed-a611-2098-7631c22fac9f)
      - [Namespaces.CompressionProtocol Field](80bb038a-5199-5d3a-1fa4-bc9563620a0e)
      - [Namespaces.DiscoInfo Field](6ab9d5df-b3ff-aac1-4547-dd7a1e170700)
      - [Namespaces.Entity Field](b09f3587-31b4-a4df-646e-efeaef28caf3)
      - [Namespaces.Ping Field](89c50988-e03a-f676-8897-278ecdec359f)
      - [Namespaces.Register Field](83b105d6-2872-3510-866e-677bec849a51)
      - [Namespaces.Roster Field](a6ba12a0-ba56-fe77-60cb-d63dc3e2eb28)
      - [Namespaces.Rostver Field](731b6b00-86f6-72df-aa84-19dc2af41ac6)
      - [Namespaces.Sasl Field](c75660bf-1a94-f1fe-98f6-b76449deca3c)
      - [Namespaces.Session Field](737a8dde-90be-3a52-92e0-959208c75049)
      - [Namespaces.Stanzas Field](23d087c4-b929-315b-43ec-452e7135b16a)
      - [Namespaces.StartTls Field](c553f753-d650-9768-738c-022226c456c8)
      - [Namespaces.Stream Field](f825c686-3081-f9e3-c165-099bfed31ea5)
      - [Namespaces.StreamManagementV2 Field](9555199d-081e-44e9-a48e-65ea5c76df18)
      - [Namespaces.StreamManagementV3 Field](0829d4ab-b7f3-ec92-3138-aadc446698bd)
      - [Namespaces.Xml Field](0e12a733-b0d9-b1ac-6565-35b3ad727027)
      - [Namespaces.Xmlns Field](5f4fb910-0088-9eaa-ffb5-4f1eab96d38b)
      - [Namespaces.XmppStreams Field](dc2e21ea-7876-c627-3988-57e473297fe1)
  - [ProtocolFeatures Enumeration](6cfabcfd-0fc3-6d2c-1520-6bc51cb2e04e)
  - [Stanza Class](e670af87-c782-c719-3b53-5ed8fcab8f22)
    - [Stanza Constructor](437bf3a0-ded0-6238-772b-d92db7af121e)
    - [Stanza Properties](169580e6-de87-8878-d290-5ed8c0c1d422)
      - [Stanza.From Property](8f38a5fe-b662-60b9-9d68-2249896b1845)
      - [Stanza.Id Property](361b6a49-4064-611b-d4ed-800993da7eee)
      - [Stanza.To Property](b38324b4-141a-9795-186b-4e4c016d3744)
    - [Stanza Methods](0138efa6-06b6-6cab-36e3-9b5c1223bfe6)
  - [Tag Class](aeb92aed-6e13-96e4-f864-d26234a205c1)
    - [Tag Constructor](860075f1-22a5-8d91-6440-aefff1c786e0)
      - [Tag Constructor](f2806391-1fc0-e0b5-0d74-5be334c445bb)
      - [Tag Constructor (String, XmlQualifiedName)](a55110ff-d4cd-603c-bbbf-489ce7d4ae3b)
    - [Tag Properties](ebdda9ad-b0f5-3072-6abb-15934a552f18)
      - [Tag.Bytes Property](da28a4a5-9aee-cced-0c2d-7951fee6ecd6)
    - [Tag Methods](ceee7993-2f7b-b41f-9d2d-eb08ff5945c5)
      - [Tag.AddChildTag Method](0ffc8e13-d20c-518c-6396-06004d4a6d33)
      - [Tag.GetBoolAttribute Method](caf77ca4-9f0e-ef28-9614-7a6c05bb614a)
      - [Tag.GetEnumAttribute(*T*) Method](a89eac4f-e709-e5b5-ba2e-7329ba34c05a)
      - [Tag.GetNextId Method](35639ed1-2c1d-422a-12b1-e4574ecd75bd)
      - [Tag.ToString Method](3a69a362-3519-8394-d356-898da18ffe2f)
    - [Tag Type Conversions](2ab81d1d-b42c-ba9e-46b3-df9cb2efdec4)
      - [Tag Implicit Conversion (Tag to String)](af72b7e8-f1fa-9a94-a2cd-9a59a1b58db4)
    - [Tag Fields](4fba8ec6-06b4-6dc9-0379-3645fc294632)
      - [Tag.Document Field](174eee64-2567-8bd2-5a00-eb5c84b4fb2c)
- [Ubiety.Common.Compression Namespace](9e89deee-48fa-8493-3d20-86bab8cf8a8a)
  - [Zlib Class](f2dbcb00-2bbb-fee3-2dda-ea757eaa524d)
    - [Zlib Constructor](90563170-5482-9bf1-b046-9bf8caeca4c4)
    - [Zlib Methods](2efd4d6c-1e64-35e0-2425-efa48a8917c2)
      - [Zlib.Deflate Method](e5faf193-a647-b1b5-1d25-89b30f1e3427)
      - [Zlib.Inflate Method](9a0b1c84-fce2-7228-eebb-61fd7769e2a5)
- [ubiety.common.disco Namespace](0e5e99a6-61e1-827b-d962-042693d0ae39)
  - [Entity Class](9ef53098-07d2-4e46-a87d-aac59103efb8)
    - [Entity Constructor](f0abe099-b123-d75a-7beb-f30e15e50215)
    - [Entity Properties](4d2cd194-2154-e663-0f24-ad46a3969321)
      - [Entity.Hash Property](900b4305-79d5-dab0-3a5a-367ce0f92ff2)
    - [Entity Methods](e8f77680-33fc-fb02-2905-de64f2e3c1f1)
- [Ubiety.Common.Disco Namespace](5226e090-1617-b5ea-ea44-31fab66788e4)
  - [IDiscoManager Interface](2fe1b2b8-c5e9-5588-4e5e-f30ab5679aee)
    - [IDiscoManager Methods](4d864123-dfe2-9c26-f344-6c629bcac593)
      - [IDiscoManager.LookupHash Method](e18aec5f-a2b3-30ce-2da2-a7c5b2b98912)
  - [RegistryDiscoManager Class](baec588c-12d5-6e38-a0ff-d8df77f705b9)
    - [RegistryDiscoManager Constructor](24d2ac0c-5a25-16e0-8561-b6f934e4b5c7)
    - [RegistryDiscoManager Methods](0afe292b-3f9a-f4b1-b44f-0ba67f8991fa)
      - [RegistryDiscoManager.LookupHash Method](d9421ceb-f0b0-5d2d-8c05-dab81b568cb1)
- [Ubiety.Common.Exceptions Namespace](5e231588-e651-4409-8e2d-e5b1afdacddf)
  - [ServerXmlException Class](c1d9dc82-1411-eae9-c03d-83b2e457be38)
    - [ServerXmlException Constructor](149c2c4a-220f-0203-4962-c6d1d5936449)
    - [ServerXmlException Properties](ab9dcfe9-fd24-623e-94f7-eb6b06e5e3f1)
    - [ServerXmlException Methods](2dc271eb-fb66-c295-79d3-b21e22a9086f)
    - [ServerXmlException Events](b30a2847-5a90-9b05-ff22-462bb29b18a3)
- [Ubiety.Common.Roster Namespace](4a433377-5767-faf9-7a43-7714d3633ea5)
  - [DefaultRosterManager Class](c69e3ec0-474c-564d-e0f3-c44f7af25517)
    - [DefaultRosterManager Constructor](0f1625e9-b491-6407-fc69-acbbfb69e6f3)
    - [DefaultRosterManager Methods](2222d29d-431f-af43-b80f-936b43946bd0)
      - [DefaultRosterManager.RequestRoster Method](4327f1b6-ecbb-635e-d5ce-d79debb02daa)
  - [IRosterManager Interface](47ce0dc4-3321-33d4-26b7-5d8fbcaa5491)
    - [IRosterManager Methods](f0ec1336-8cdf-7aa5-09f8-f049a2d7c6ed)
      - [IRosterManager.RequestRoster Method](72f137e2-c5bd-e221-a899-1ca1a7fb8aff)
- [Ubiety.Common.Sasl Namespace](cd4c5a69-1ab4-14a6-950f-4a758c4f8386)
  - [Md5Processor Class](0932c792-b629-8b64-552e-671dd7f9ce4d)
    - [Md5Processor Constructor](667cc5c9-cd90-6bd9-6500-f87101811ae9)
    - [Md5Processor Methods](b5dc2dab-9673-d03c-6ad9-6bb880d53d41)
      - [Md5Processor.Dispose Method](2f55d82e-29be-4997-cf8f-0a8116043bf9)
      - [Md5Processor.Initialize Method](5565dbda-81da-3b11-6856-f2de23c10dcf)
      - [Md5Processor.Step Method](5519e141-714e-b562-a0f7-600dc0596aa9)
  - [PlainProcessor Class](807a6550-8874-db88-ec3e-f4db571b5f1b)
    - [PlainProcessor Constructor](7a829f35-b979-9779-5cd2-1e94183e2992)
    - [PlainProcessor Properties](d19626ee-8ce3-da2b-1097-b644ecefd7fb)
    - [PlainProcessor Methods](7c4a3666-123c-668f-251f-1838f83e8e6f)
      - [PlainProcessor.Initialize Method](8aceab24-eb50-e86f-2fda-2053eac93fc6)
      - [PlainProcessor.Step Method](b772e9db-01bc-fb3b-e265-6ef67b1469fd)
    - [PlainProcessor Fields](b310746c-4cbf-8c74-9f3d-bf915d1bb057)
  - [SaslProcessor Class](404d8bfd-4c20-8577-d111-2d3d0e27f300)
    - [SaslProcessor Constructor](2d2ff73f-09b4-18d9-4f2b-a692cc55df4b)
    - [SaslProcessor Properties](2e2bb460-8ee1-e2b4-1694-a9eb927156f4)
      - [SaslProcessor.Item Property](8d7e1af3-62f0-1936-ae2c-da93df6a57a8)
    - [SaslProcessor Methods](03682581-de03-5def-243b-d26d316ca86d)
      - [SaslProcessor.CreateProcessor Method](deac9cd0-7f1d-c0bd-bc3a-267f1fed812d)
      - [SaslProcessor.HexString Method](23f2d621-181a-8125-86cf-2f8e28ca6291)
      - [SaslProcessor.Initialize Method](a37ca787-fa87-20b8-1ef1-4e7c26784e2f)
      - [SaslProcessor.NextInt64 Method](b4dfbb0d-fb6e-e4fd-c675-53fcb581537e)
      - [SaslProcessor.Step Method](aaddc82c-ba0e-2f14-ce9d-7fb8c63bbd51)
    - [SaslProcessor Fields](e87f426c-d4ea-2e5d-dea3-1676e90b8952)
      - [SaslProcessor.Id Field](7d4e707f-def5-5a40-7ed4-d2105a2b1e92)
      - [SaslProcessor.Password Field](bce2ce0f-7a8c-29d2-d975-34ce2e65d6ea)
  - [ScramProcessor Class](0b7b7bfd-434c-03e5-50db-fb12e68f7434)
    - [ScramProcessor Constructor](ad7cc0e7-a8aa-98ea-8ad2-02954c784396)
    - [ScramProcessor Properties](7f57162a-5432-7b33-ee96-50418c5cba69)
    - [ScramProcessor Methods](5f1f9261-7ced-5824-0087-58f57d72e2d5)
      - [ScramProcessor.Initialize Method](f85a5f20-0c1c-30f3-6e4a-d897a15ff2a8)
      - [ScramProcessor.Step Method](16986bfe-1b6d-c0c0-ef00-18e0aa23dae7)
    - [ScramProcessor Fields](cf5f3079-981f-ea33-bc7b-f5ecfb7b39d4)
- [Ubiety.Core Namespace](aced5668-5a9c-1ea2-e16e-3faf214f48b3)
  - [Bind Class](f56ba217-eeab-d00d-f422-5814e1b2ee34)
    - [Bind Constructor](9983c2ef-477b-53e4-c192-4b7d1933a9bc)
    - [Bind Properties](732e0480-1e38-df8a-c468-4b482e358a46)
      - [Bind.JidTag Property](1fd0de7f-3c55-5e6a-7536-7156087b51bb)
    - [Bind Methods](3ca995db-03b2-87b4-7f5c-50b607db9bb0)
  - [Compression Class](289854c4-36d0-6bb7-24bc-61691c8bb978)
    - [Compression Constructor](9ad33f4b-a304-35be-8f68-2adc96aed5df)
    - [Compression Properties](f2cc1d4e-99de-1d0d-6a23-db74908c8da6)
      - [Compression.Algorithms Property](c713b6da-d1e2-b1de-5fe5-7e9ca466b0da)
    - [Compression Methods](a91042bf-a60e-de6a-5bc9-d1c5c0c14047)
  - [Error Class](58f4f438-c3a5-2e4e-6e7a-79f1051ce7e0)
    - [Error Constructor](e294281e-9290-6759-28a6-0ad260b6b768)
    - [Error Properties](c16dfce3-29ee-4e64-bc70-9d24c4da87da)
    - [Error Methods](98a07509-6e35-999c-d074-c4394778d5c2)
  - [Features Class](0278e58f-aac4-e39e-718b-60d613eef553)
    - [Features Constructor](f2db34ba-ac46-d655-bece-ef26ec77b242)
    - [Features Properties](6405dd43-b64d-f970-3657-b82bb5d1664f)
      - [Features.Compression Property](df86a902-145f-a15b-a754-1420e52a7c61)
      - [Features.SM Property](96c8f3fd-27e1-810d-79b1-9b4e9ab48e8e)
      - [Features.StartSasl Property](247c92dc-7f46-61e2-f310-5b66aa0b3953)
    - [Features Methods](b36af6d7-44e3-b90c-4472-6f36b4186450)
      - [Features.Update Method](3675a8b3-bb8c-1a23-23a5-d66a3fbf9b33)
  - [GenericTag Class](3dacf0fc-e5da-f638-8dc3-5360b5f64837)
    - [GenericTag Constructor](400b4385-4675-6670-ed08-2c3528933356)
    - [GenericTag Properties](02c70ee8-da2d-3ab1-88d6-86dcb1d2300b)
    - [GenericTag Methods](26eb9a05-0746-200c-ed02-69285c05140f)
  - [Jid Class](e5b42afc-e2ee-7e29-93ca-2b1b009edf82)
    - [Jid Constructor](81d676f6-49e1-3818-f857-373409729bf5)
    - [Jid Properties](76dfd604-36c5-8049-ad2a-2c960bbb458e)
      - [Jid.UserJid Property](b40898ad-5e43-562d-3eba-f98ee46307b5)
    - [Jid Methods](8cab556b-99eb-c977-caa2-6b6f8e17beb3)
  - [Mechanism Class](62df5643-e279-e31b-48af-3e2364c56d91)
    - [Mechanism Constructor](d4af9f1b-4511-ca4d-6321-0958556f7a7c)
    - [Mechanism Properties](d178c5eb-5e7f-893b-48f9-65d89293d5a7)
      - [Mechanism.Text Property](10fccef2-5f68-2c72-75c8-8efef5233a69)
      - [Mechanism.Type Property](549b6088-0cfe-5dd1-8418-9e32fea30f6a)
    - [Mechanism Methods](f515057e-74ab-0308-38c0-dd4ec1dd66a1)
      - [Mechanism.GetMechanism Method](54acd59a-8a57-a674-28d0-18c98ceadd79)
      - [Mechanism.GetType Method](5b33337f-53d2-c2e4-bedb-b7e2cdc188f2)
        - [Mechanism.GetType Method (String)](5e51f587-0be6-4a42-36bf-38a92f7d6ae2)
  - [Mechanisms Class](08706880-a516-52e5-1fa9-b35a4e7a0d1d)
    - [Mechanisms Constructor](917b23e5-745a-e251-9aab-a40293ec14de)
    - [Mechanisms Properties](45197764-0d5f-baad-4494-e6f0c4a9e6d9)
      - [Mechanisms.SupportedTypes Property](ecd0458b-e265-8d5b-0e4b-93da952b507b)
    - [Mechanisms Methods](94589064-ec32-830b-1607-be05eb02870c)
  - [MechanismType Enumeration](b1643170-ff5d-107c-82d0-f3c8837e8a1a)
  - [StartTls Class](52a8d5fc-70fa-49fc-f7f0-b130f18763a5)
    - [StartTls Constructor](95c23a36-506e-929e-21c7-bd17d5305d21)
    - [StartTls Properties](103b652e-5a1e-9ec2-66ef-13b1dfbaa9c5)
      - [StartTls.Required Property](503dead1-bd4c-6572-3de6-26e6835e5804)
    - [StartTls Methods](652c6802-ca9b-862f-0880-dd44c01555cb)
  - [Stream Class](a0611624-c14b-4adc-6c45-2c99300da464)
    - [Stream Constructor](2eff7ff9-272c-f3a0-974c-c553d1f6c934)
    - [Stream Properties](0cce9a2b-b7ca-97ff-4dc3-eaf78d0a42a8)
      - [Stream.Error Property](ab699f62-a09f-b112-246e-f8511308ae57)
      - [Stream.Features Property](bfc94fdc-bf3f-80b3-b79b-f621d09e150f)
      - [Stream.Language Property](6544afae-2e80-1084-7ec5-1e11928de120)
      - [Stream.Namespace Property](2d863deb-5c4e-78b0-7178-7a34a0295745)
      - [Stream.Version Property](1ef20aae-8263-5c9e-490d-d405bb44e915)
    - [Stream Methods](96ac21c6-31d1-265b-c27c-3b2a48cd889a)
      - [Stream.StartTag Method](8610d6b2-788c-9f2f-a78e-1b570482ffe2)
- [Ubiety.Core.Disco Namespace](81eda19a-0f65-ef64-bde0-efeb6509de7d)
  - [C Class](d0da3ba0-29b4-c743-4fd0-3f8c1e354a97)
    - [C Constructor](4290e1ce-39cb-b992-f854-1091e8b76229)
    - [C Properties](94bc330e-8d9a-210f-47f8-e4a3692c4c56)
      - [C.Node Property](4128cef7-238a-a807-1eb2-e3a73a0e57b3)
      - [C.Ver Property](4cefa404-af18-6c63-e340-707860c69b8c)
    - [C Methods](0fb811d4-80bd-a0b1-2c70-8ec9dd249e39)
- [Ubiety.Core.Iq Namespace](13843980-17a1-e355-3861-83b3eda7c166)
  - [Iq Class](e938f5c8-40c4-4e97-9a6e-f31df604036b)
    - [Iq Constructor](7f8e81ef-d225-fd53-fea9-88880b7d2c19)
    - [Iq Properties](5fea6eef-1167-2ac7-7876-e61cd96600ac)
      - [Iq.IqType Property](6cc85fad-7684-6ba0-9112-e59e5eb31326)
      - [Iq.Payload Property](46ad5d90-73a9-fcc2-c88f-152d45914e9a)
    - [Iq Methods](8541a4c4-06e5-d32a-6edb-69d786b14372)
  - [IqType Enumeration](938015c7-24e0-b95d-adeb-ceb3ed93a841)
  - [Query Class](7d80b94d-cc2c-f415-8493-afd6447876c8)
    - [Query Constructor](7a116ab7-a397-00a8-bb24-28851e9c3a4d)
    - [Query Properties](72f6f7d2-9502-f178-c4b1-ed4b5b4dea1b)
    - [Query Methods](4125176d-743f-cc8c-9754-9b1511661e6b)
- [Ubiety.Core.Sasl Namespace](50c3ad1d-7d38-f89a-9095-b5a01e4289de)
  - [Auth Class](c7862cdd-02ef-97c9-130f-394cfedeb918)
    - [Auth Constructor](fb5ef464-210a-d05c-5496-d06281ad4988)
    - [Auth Properties](6d80aac6-ebfb-af47-e4d0-46fad436bcdc)
      - [Auth.Mechanism Property](456633ac-8000-e807-f0c2-0fe5882bed51)
      - [Auth.Text Property](5532221d-9c35-f411-2c41-6d2ed74898cc)
    - [Auth Methods](83316c57-43f3-9622-ccf2-6a13907a7f0b)
- [Ubiety.Core.SM Namespace](e8bce8a2-5e14-32b6-639e-d75b28f79ce7)
  - [A Class](a6410775-cf12-8a54-eda7-4c653810155a)
    - [A Constructor](72d32faf-1a21-eb4d-aaa6-ffe78ede684f)
    - [A Properties](1a31d585-c219-b162-872a-9907fa25129d)
      - [A.H Property](e396fc54-60d3-f175-222b-4e2fd1935669)
    - [A Methods](deefa521-f9c6-e3d7-1db6-9af84af8a9b7)
  - [Enable Class](4446add4-4a2e-b8da-56a8-a1e471d53407)
    - [Enable Constructor](6519134f-4f7d-6632-9a76-2a324ccf15c9)
    - [Enable Properties](9bd7dd43-dc85-c910-51ce-15c2e1b72f1a)
    - [Enable Methods](27788a9f-df8d-4bed-439f-5342156f577b)
  - [Enabled Class](1e70673e-0cad-c2d9-8d8d-a8f4f8ae3eac)
    - [Enabled Constructor](28ea3ae1-8800-4837-2e8a-541bb15ab98f)
    - [Enabled Properties](227dda41-8973-d11d-053d-3b23d6e8fcc9)
      - [Enabled.Id Property](a493a262-eae9-e70d-6667-f83053d97ac1)
      - [Enabled.Resume Property](fc3c3e49-3147-0865-88ba-0e26e8477152)
    - [Enabled Methods](cd61ca12-561e-114c-e8c4-fa8d96f20695)
  - [Failed Class](37ab0515-1ab6-c1f4-db6f-5ba9cb75db97)
    - [Failed Constructor](878888d0-ec09-807e-43e0-c76dd3fb714b)
    - [Failed Methods](f8713f36-00cd-5c3a-1d3f-dd4084957ca7)
  - [R Class](bf66e6dc-4763-57a4-5a5f-0402e79f5876)
    - [R Constructor](7745dfaf-74fe-d612-a754-6aa16a163852)
    - [R Properties](7eb19039-3a52-5d03-2b11-cabc8d504c05)
    - [R Methods](4bb36a4e-0b07-1373-affa-96a7ece024f4)
  - [SM2 Class](23258cf6-0a49-28a8-f5b6-90441c8d8a78)
    - [SM2 Constructor](b344a0da-c618-e8ba-d11e-4bf3c5b82d47)
    - [SM2 Properties](9c09326c-9636-40b3-6625-3a5774e3e5cc)
    - [SM2 Methods](a8410562-90df-6af5-e8cf-4dbdc16b8df7)
  - [SM3 Class](1ad4f33b-a991-32fb-97ff-c05b1335beaa)
    - [SM3 Constructor](e7e4ff62-1778-2df1-b54b-f443a7ad4cc6)
    - [SM3 Properties](97a9ce85-5d9b-9693-c35c-c38e182f8f2c)
    - [SM3 Methods](afbe15de-57a7-6c39-ca46-b365b82a3fe8)
- [Ubiety.Infrastructure Namespace](7349ff87-094b-cd2f-6f99-c82eea293e78)
  - [ErrorEventArgs Class](be6c8c69-04b0-1030-ddac-26d83d952d5c)
    - [ErrorEventArgs Constructor](a8c4a56c-3182-a966-2ded-298a449bbb19)
    - [ErrorEventArgs Properties](a94a24c6-2eb5-7b57-8982-13b886ed53cc)
      - [ErrorEventArgs.Message Property](ba389af5-94e7-b253-79e4-21be15515bf2)
      - [ErrorEventArgs.Severity Property](bba503d6-4319-312e-34ae-1b9bc4acf47b)
      - [ErrorEventArgs.Type Property](f7117786-cf8f-eadd-bdcf-4b15af127afb)
    - [ErrorEventArgs Methods](ba09b503-64db-42ec-2b4b-23b030b6737d)
  - [IUpdateable Interface](fd3e20c8-cdab-0cef-3be4-cd04e0327fad)
    - [IUpdateable Methods](284bface-4625-5a49-75b4-1f2cc54a51c0)
      - [IUpdateable.Update Method](b855b16f-ad53-6d35-66c0-1f3e9cdbdfc5)
  - [TagEventArgs Class](81eb7b62-4b7b-d2ed-8e62-3fb97b104d4e)
    - [TagEventArgs Constructor](38d8a242-e376-de61-90f3-256d6a2399ce)
    - [TagEventArgs Properties](577a7d52-5322-1577-ee86-546be4e5b041)
      - [TagEventArgs.Tag Property](78a310ce-787f-4ce2-1d8b-79d3a719095d)
    - [TagEventArgs Methods](00be285a-5ef9-18df-45b5-2838a8945b69)
  - [XmppEvents Class](53afd0a6-cf28-9557-2822-4438f8918532)
    - [XmppEvents Constructor](2315e435-b9aa-28ea-c32d-bd4dfa651b2a)
    - [XmppEvents Methods](a7dc22a1-8ff0-016d-557b-271f4011b0c9)
      - [XmppEvents.Connect Method](e3cf2de0-c2d0-f654-8d52-4efed272a192)
      - [XmppEvents.Disconnect Method](d8114151-21ce-6295-a702-6c636e542546)
      - [XmppEvents.Error Method](ee55ece0-5440-7ae1-6abc-0087ba4cbaa2)
        - [XmppEvents.Error Method (Object, ErrorEventArgs)](28a5af55-dcf3-a290-c9a7-b1a09d438a75)
        - [XmppEvents.Error Method (Object, ErrorType, ErrorSeverity, String)](2902d9f3-c366-c185-080e-13e93a0d5a26)
        - [XmppEvents.Error Method (Object, ErrorType, ErrorSeverity, String, Object[])](8ddff1f8-71e4-cccc-8089-aea61e4a09ac)
      - [XmppEvents.NewTag Method](4a85b3f2-6951-d851-41f2-19c70e9870e0)
        - [XmppEvents.NewTag Method (Object, Tag)](18259bc3-3c23-d7d4-a28c-a2563509bca4)
        - [XmppEvents.NewTag Method (Object, TagEventArgs)](8d0803be-54a9-9801-12b6-ecdb3903d6f1)
      - [XmppEvents.Send Method](4ba10708-8a06-4ca1-54c5-14a876412417)
        - [XmppEvents.Send Method (Object, Tag)](48b07d45-777d-f94c-082a-6617a6cb2905)
        - [XmppEvents.Send Method (Object, TagEventArgs)](673cd033-1ed3-892b-dd4f-1da7b31b1b7b)
    - [XmppEvents Events](62d35189-d839-746c-d5da-6af89aa08d6e)
      - [XmppEvents.OnConnect Event](1beaaccf-8ec3-316e-3f61-08ae7417643a)
      - [XmppEvents.OnDisconnect Event](90d2aa34-745f-5189-3024-f445e6f386df)
      - [XmppEvents.OnError Event](30c46093-3540-057e-ba14-326a04038508)
      - [XmppEvents.OnNewTag Event](c27336b1-7195-9d70-ef50-aa01cf886291)
      - [XmppEvents.OnSend Event](b4b874e9-ec26-2c53-cf21-75597a6b9476)
  - [XmppSettings Class](fcf7b0da-0faf-c1dd-cb5f-6f124512d2db)
    - [XmppSettings Constructor](fefc3d0a-b8c1-7be1-e002-e082ee6b9f49)
    - [XmppSettings Properties](8d62f47c-956c-444a-e22b-45cdb09b188b)
      - [XmppSettings.AuthenticationTypes Property](db0cbf42-e75b-0631-efcf-36f84e1cdcb3)
      - [XmppSettings.DiscoManager Property](3087a342-6d90-83c7-47cc-bb4cb85c7ebf)
      - [XmppSettings.Hostname Property](f6eb8918-795e-6998-a2b0-9d712fb50889)
      - [XmppSettings.Id Property](ae70b898-1726-7b43-8abc-e39655239461)
      - [XmppSettings.Password Property](5d1e5055-4a69-22d9-adb3-ca5dc4a2826b)
      - [XmppSettings.Port Property](cef58c5d-35a4-90f9-d087-3c081cab750b)
      - [XmppSettings.Ssl Property](1fba8655-1c9e-63d2-d90e-3eb91faf8c04)
      - [XmppSettings.StartTls Property](5e30a657-2035-d05a-62f5-90af9c9b13ac)
    - [XmppSettings Methods](b6df5fcc-80a5-a00b-7997-50b77e16b385)
- [Ubiety.Infrastructure.Attributes Namespace](b3322d95-2f05-dd20-502c-b838cb02b69e)
  - [CompressionAttribute Class](6edc8b0a-1cc9-7975-af34-c39db46757a6)
    - [CompressionAttribute Constructor](8ead572c-2897-b935-2961-29f5f18423eb)
    - [CompressionAttribute Properties](3a2b0578-b57d-4f31-c0b9-c7c2d8c3e5ea)
      - [CompressionAttribute.Algorithm Property](595e6694-d24c-1c46-edbd-11470e4e0e4c)
      - [CompressionAttribute.ClassType Property](005b2640-172a-3ffa-b8b9-c9cab9b31a87)
    - [CompressionAttribute Methods](9c0286cb-45c7-fc62-10f5-1b7baac51ebc)
  - [XmppTagAttribute Class](74c401d3-9226-0cc7-2110-f3d64b842cfc)
    - [XmppTagAttribute Constructor](f98295b5-a28f-5cb7-ff2f-b1384e0fc78d)
    - [XmppTagAttribute Properties](c0aa038a-ac6a-02a8-c22f-64229d0228c9)
      - [XmppTagAttribute.ClassType Property](e9be5525-f211-e463-61e8-993c3e99b85d)
      - [XmppTagAttribute.Name Property](5ce99e91-eea7-5641-1995-425c0ee48901)
      - [XmppTagAttribute.Namespace Property](5da703a7-8255-b289-8c3f-567631ab7908)
    - [XmppTagAttribute Methods](44b7a607-e3df-552f-b18c-3cebeb62710d)
- [Ubiety.Infrastructure.Extensions Namespace](d5e54d6e-1130-1bb8-6df6-c2552c8f474c)
  - [AssemblyExtensions Class](0d44073c-5b18-70e9-adc3-263d4b608e8c)
    - [AssemblyExtensions Methods](a7118d62-3785-1b34-00cc-79184dcc9f2c)
      - [AssemblyExtensions.GetAttributes(*T*) Method](bad43ad3-5f26-154e-3759-3fbf14d167e2)
  - [ByteExtensions Class](45df1a86-5774-10ad-b2d2-a55868715168)
    - [ByteExtensions Methods](4513bbb8-283d-5f3e-a72a-c8af0e650d71)
      - [ByteExtensions.Clear Method](16e3bb61-e312-2ed7-b6df-1424052ff99d)
      - [ByteExtensions.TrimNull Method](22fd0472-957c-bb8a-ba2f-5ca5c5dc21d6)
  - [EnumerableExtensions Class](fed9a870-761d-3e60-9925-4d3e7ba6cbea)
    - [EnumerableExtensions Methods](03307d14-a235-ab70-1787-ab6a6911ad87)
      - [EnumerableExtensions.Apply(*T*) Method](fcea6e82-887f-e20d-9684-1903b204f2bd)
  - [TypeExtensions Class](a77b48c3-d237-008f-9228-d6b5c582e853)
    - [TypeExtensions Methods](78bf80ca-a3b9-fb15-ca54-7b3edd1da111)
      - [TypeExtensions.GetCustomAttributes Method](11a1c34c-4ed4-69dc-e6ec-118776da8c7c)
        - [TypeExtensions.GetCustomAttributes(*T*) Method (Type)](9be4e162-2805-972c-7927-243bb1e4cab6)
        - [TypeExtensions.GetCustomAttributes(*T*) Method (Type, Boolean)](2b989cad-d0d8-074f-9158-495914d7c998)
- [Ubiety.Registries Namespace](791581ab-2905-a80d-d171-7e10c795463e)
  - [CompressionRegistry Class](17011c86-9c29-42f2-8614-8582fa3dfe21)
    - [CompressionRegistry Properties](a162aa75-5538-dda7-5af7-ec1daebbd7a5)
      - [CompressionRegistry.AlgorithmsAvailable Property](959df12c-bc6c-a783-cc24-9ce138aed451)
    - [CompressionRegistry Methods](60ebdf62-c21c-11cb-2fa6-0cef831268ef)
      - [CompressionRegistry.AddCompression Method](6e951da4-be32-bc1a-91b6-4327ad51d163)
      - [CompressionRegistry.GetCompression Method](a7a0fceb-89e8-2f28-8231-717ddf912344)
      - [CompressionRegistry.SupportsAlgorithm Method](35f47412-ce93-22ec-0737-20c74176f90e)
  - [TagRegistry Class](362439f4-c194-12b4-2981-9131a9df04ba)
    - [TagRegistry Methods](c59d9cbe-6144-2aa2-c696-6cf1e98a57f4)
      - [TagRegistry.AddAssembly Method](4a32fb53-db34-facc-2755-c823ec728400)
      - [TagRegistry.GetTag Method](9f8baaa7-1320-583d-2ae5-95c2e61d376d)
        - [TagRegistry.GetTag(*T*) Method (XmlQualifiedName)](40c97ca5-a686-b8ee-f043-3a06fd61e9e3)
        - [TagRegistry.GetTag(*T*) Method (String, String)](d4c878c6-f055-7345-9a6c-745360e576ba)
- [Ubiety.States Namespace](20b8e647-a51d-e28e-4067-8a55aba73e08)
  - [BindingState Class](11efcd95-e7d2-b55e-4060-c70f7f759dc9)
    - [BindingState Constructor](bf8f7300-89a6-c634-434e-6678d1d65152)
    - [BindingState Methods](d1008138-c0c7-9237-84eb-a2e7d8a6d5cd)
      - [BindingState.Execute Method](4c784b04-00e3-0b32-c8b6-3157816c7cc0)
  - [CompressedState Class](bb2e3ae7-d026-3679-ef38-112e77bc08d6)
    - [CompressedState Constructor](076e6134-0051-9c98-2098-f7a4b8c27ff5)
    - [CompressedState Methods](d8ac22ab-8d39-3ab6-6edf-565ae7ac6e9e)
      - [CompressedState.Execute Method](e6fe42c1-4ebe-9a69-6e46-bdfebccf632e)
  - [ConnectedState Class](ce46ee4d-8bc5-ade2-99f8-6814de6b441e)
    - [ConnectedState Constructor](deb242d6-f12a-4310-6ef8-9c5a0e9bfe71)
    - [ConnectedState Methods](4f46f5a6-c0ef-95a4-3150-4860f287e78f)
      - [ConnectedState.Execute Method](19868f80-d368-b890-55f9-1c1f6352c077)
  - [ConnectingState Class](55cc6f19-6106-9ee7-cda1-bbbd0b539d6e)
    - [ConnectingState Constructor](b1087577-425f-7f44-203f-dba6d315352c)
    - [ConnectingState Methods](87d4e945-caaa-b1f5-5414-b2535a766ba8)
      - [ConnectingState.Execute Method](49aa90d6-cc14-973e-c1a8-f43ad101a213)
  - [DisconnectedState Class](a0e55f48-1bcb-43fd-c6f9-4195e05f05e5)
    - [DisconnectedState Constructor](f940a4ec-cb45-a035-6fab-2c4cd5c25c36)
    - [DisconnectedState Methods](d4923cac-a125-01fb-e9c4-5ff3c2953213)
      - [DisconnectedState.Execute Method](017bdfa2-33d7-3b57-6516-4d86b5270e13)
  - [DisconnectState Class](efc1e411-ba4a-b381-4802-9ba689997a42)
    - [DisconnectState Constructor](a3e3b202-27f9-4fb8-b5c3-3f1964968de0)
    - [DisconnectState Methods](0ff09715-6124-c088-4f96-12a5cdf8ca10)
      - [DisconnectState.Execute Method](4d2ae14e-bbbd-5148-d8af-ae0bab669124)
  - [IState Interface](89797f66-509e-c464-6995-1c6a0d12b034)
    - [IState Methods](1c680ec0-f2de-9d9a-0a66-de616803803e)
      - [IState.Execute Method](8a544e00-3b66-b849-1e5f-3ff523769af3)
  - [ProtocolState Class](953c9694-4889-010e-7be3-c9913ba654da)
    - [ProtocolState Properties](a4b51bee-dd5b-19e3-fd31-b7198fe46e0a)
      - [ProtocolState.Algorithm Property](1d50a380-df90-edc3-f114-ae989b8e1f09)
      - [ProtocolState.Authenticated Property](691b0305-5858-63d8-35c9-8291d87a0d92)
      - [ProtocolState.Compressed Property](c6e70fa1-a073-349d-5c42-d237a484e507)
      - [ProtocolState.Encrypted Property](be883c9b-f264-3f49-7bc7-27a645cab151)
      - [ProtocolState.Events Property](05ea61b4-130e-c755-8fc3-1aa5d4cedc2d)
      - [ProtocolState.Features Property](6ecb326a-165e-073b-b203-f14ff9173de0)
      - [ProtocolState.Processor Property](ed1e0d20-df16-b114-8577-0cb15e98f93f)
      - [ProtocolState.RosterManager Property](ff0c3a17-65e8-4320-5c1c-e823b7a3a5d2)
      - [ProtocolState.Settings Property](8e15ba6b-54e8-f28f-38ce-d5578c445fe5)
      - [ProtocolState.StanzaCount Property](8f014e5f-96ee-f29f-6bc8-9822b2687515)
      - [ProtocolState.State Property](e4c61dbc-e266-8236-1bdb-89f58e24c0da)
      - [ProtocolState.UnacknowlegedStanzas Property](b50ef641-ad58-d89c-7740-78d43393d7e4)
      - [ProtocolState.UseIPv6 Property](f33c9af7-b0f4-76e9-c180-9819d3b92f89)
  - [RunningState Class](bedf8ed8-3cb0-daae-454a-4314c1159b1d)
    - [RunningState Constructor](529de709-7e5e-6614-f40c-4fa5bcf9e951)
    - [RunningState Methods](a43e0bac-4b9e-62ed-8e9d-e5c252335119)
      - [RunningState.Execute Method](ae97b113-4764-7a46-c375-f53340f7a3f2)
  - [SaslState Class](ff64db6e-99c6-c2fd-dbc8-86c2477b9cf1)
    - [SaslState Constructor](0edf2397-7f5a-c11e-54d7-fb0ddfa944df)
    - [SaslState Methods](e5c17969-096d-7a82-01b5-f172e5dfdc48)
      - [SaslState.Execute Method](0cf600bc-ab44-8622-5df4-db22660982cc)
  - [ServerFeaturesState Class](303d1faf-f50e-6701-adb0-266b770a61ea)
    - [ServerFeaturesState Constructor](543b1dda-72d4-bf6c-d141-22c39d970c45)
    - [ServerFeaturesState Methods](d0801f05-10bf-4023-bab4-6e5ee7e0a8c5)
      - [ServerFeaturesState.Execute Method](33bd6132-eac2-1d58-10bc-8eb870a69efd)
  - [SessionState Class](98b9ae7a-f614-9f49-22d2-3f70fc10c24e)
    - [SessionState Constructor](c41b9c4d-e8b3-950d-eb6c-31243e6c1048)
    - [SessionState Methods](b2c5ae60-a622-ae34-9163-4207ccd470f8)
      - [SessionState.Execute Method](e4704f6b-7453-7657-6332-d6662c9d9ebe)
  - [StartTlsState Class](76f8a6e2-bf7b-a153-65ea-88d5c9f38da0)
    - [StartTlsState Constructor](abb0314b-793e-04f9-336f-9de6710dec7e)
    - [StartTlsState Methods](1837c0ab-21f9-b144-ff69-37aba1408872)
      - [StartTlsState.Execute Method](eed54def-e94b-4b00-da81-63c08c22d890)
  - [StreamManagementState Class](888fd2aa-faa8-5c6a-f46f-3dab992b7b62)
    - [StreamManagementState Constructor](e04a8b5b-af3e-fd96-e5f2-2ff633b96aa2)
    - [StreamManagementState Methods](7348f3ff-618d-a3f5-7227-b3b788a49489)
      - [StreamManagementState.Execute Method](ba53a988-54a3-771a-dbf1-b4354f390e98)
