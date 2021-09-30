IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'00000000000000_CreateIdentitySchema')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703011050_test1')
BEGIN
    CREATE TABLE [DotAudit] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [UserId] nvarchar(max) NULL,
        [Tractor] int NOT NULL,
        [Date] datetime2 NULL,
        [DriversLicense] bit NOT NULL,
        [DotCard] bit NOT NULL,
        [ExtraLogBook] bit NOT NULL,
        [PitCard] bit NOT NULL,
        [Tablet] bit NOT NULL,
        [DvirBook] bit NOT NULL,
        [Registration] bit NOT NULL,
        [InsuranceCard] bit NOT NULL,
        [Ifta] bit NOT NULL,
        [LogBook] bit NOT NULL,
        [EldGuide] bit NOT NULL,
        [PermitBook] bit NOT NULL,
        [PostAccidentKit] bit NOT NULL,
        [BlankAccidentReport] bit NOT NULL,
        [OregonFuelPermit] bit NOT NULL,
        [DriverSignature] nvarchar(max) NULL,
        CONSTRAINT [PK_DotAudit] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703011050_test1')
BEGIN
    CREATE TABLE [EndRouteCheck] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Tractor] int NOT NULL,
        [Epj] int NOT NULL,
        [Date] datetime2 NOT NULL,
        [Trailer] nvarchar(max) NULL,
        [RouteNumber] int NOT NULL,
        [LoadQualitySurvey] nvarchar(max) NULL,
        [TurnInBols] nvarchar(max) NULL,
        [TurnInAllPaperwork] nvarchar(max) NULL,
        [PalletJack] nvarchar(max) NULL,
        [ReturnMisPicks] nvarchar(max) NULL,
        [ClearTrailer] nvarchar(max) NULL,
        [SweepTrailer] nvarchar(max) NULL,
        [ReportTrailer] nvarchar(max) NULL,
        [RetunDvir] nvarchar(max) NULL,
        [ReportEquipmentDamages] nvarchar(max) NULL,
        [StrapsHanding] nvarchar(max) NULL,
        [TrailerShuttle] nvarchar(max) NULL,
        [TrailerLocation] nvarchar(max) NULL,
        [DriverSignature] nvarchar(max) NULL,
        CONSTRAINT [PK_EndRouteCheck] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703011050_test1')
BEGIN
    CREATE TABLE [OperatorEquipment] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [UserId] nvarchar(max) NULL,
        [RouteNumber] int NOT NULL,
        [Epj] int NOT NULL,
        [FluidLeaks] nvarchar(max) NULL,
        [Tires] nvarchar(max) NULL,
        [Forks] nvarchar(max) NULL,
        [HandGuards] nvarchar(max) NULL,
        [SafetyWarnings] nvarchar(max) NULL,
        [OperatorsManual] nvarchar(max) NULL,
        [PowerCord] nvarchar(max) NULL,
        [CapacityPlate] nvarchar(max) NULL,
        [ServiceBreak] nvarchar(max) NULL,
        [SteeringOperation] nvarchar(max) NULL,
        [DrivingControl] nvarchar(max) NULL,
        [HoistControl] nvarchar(max) NULL,
        [Horn] nvarchar(max) NULL,
        [LightsAlarms] nvarchar(max) NULL,
        [HourMeter] nvarchar(max) NULL,
        [BatteryIndicator] nvarchar(max) NULL,
        [ManualForks] nvarchar(max) NULL,
        [Wheels] nvarchar(max) NULL,
        [Maneuverability] nvarchar(max) NULL,
        [Handle] nvarchar(max) NULL,
        [ManualFluidLeaks] nvarchar(max) NULL,
        [ReleaseLever] nvarchar(max) NULL,
        [CracksWear] nvarchar(max) NULL,
        [HandTruckWheels] nvarchar(max) NULL,
        [DockCracks] nvarchar(max) NULL,
        [Bent] nvarchar(max) NULL,
        [MissingHardware] nvarchar(max) NULL,
        [Pins] nvarchar(max) NULL,
        [LiftHandleDamage] nvarchar(max) NULL,
        [Comments] nvarchar(max) NULL,
        [Signature] nvarchar(max) NULL,
        [Date] datetime2 NOT NULL,
        CONSTRAINT [PK_OperatorEquipment] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703011050_test1')
BEGIN
    CREATE TABLE [Trip] (
        [Id] int NOT NULL IDENTITY,
        [IsTeamRoute] bit NOT NULL,
        [Name] nvarchar(max) NULL,
        [UserId] nvarchar(max) NULL,
        [RouteNumber] int NOT NULL,
        [Tractor] int NOT NULL,
        [Trailer] nvarchar(max) NULL,
        [StartTime] datetime2 NULL,
        [EndTime] datetime2 NULL,
        [StartMiles] decimal(18,2) NULL,
        [EndingMiles] decimal(18,2) NULL,
        [Inspections] int NOT NULL,
        [BHPU] int NOT NULL,
        [XDock] int NOT NULL,
        [HourlyYard] decimal(18,2) NOT NULL,
        [Chains] int NOT NULL,
        [Delay] decimal(18,2) NOT NULL,
        [Sleeper] int NOT NULL,
        [Meals] int NOT NULL,
        [Pallets] int NOT NULL,
        [RoadStops] int NOT NULL,
        [SuperStops] int NOT NULL,
        [Shuttle] int NOT NULL,
        [Temp] nvarchar(max) NULL,
        [MiscExpense] decimal(18,2) NOT NULL,
        [Comments] nvarchar(max) NULL,
        [Signature] nvarchar(max) NULL,
        CONSTRAINT [PK_Trip] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200703011050_test1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200703011050_test1', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200706200115_IdentityNameField')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [FullName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200706200115_IdentityNameField')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200706200115_IdentityNameField', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200706204718_CustomUserData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200706204718_CustomUserData', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200712071402_TripDefaultValues')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200712071402_TripDefaultValues', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200712210835_firstlastname')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'FullName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [AspNetUsers] DROP COLUMN [FullName];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200712210835_firstlastname')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [FirstName] nvarchar(100) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200712210835_firstlastname')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [LastName] nvarchar(100) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200712210835_firstlastname')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200712210835_firstlastname', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210930045802_InitialTest')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210930045802_InitialTest', N'3.1.5');
END;

GO

