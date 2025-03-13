CREATE TABLE Users (
    userID INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(50) UNIQUE NOT NULL,
    email NVARCHAR(100) UNIQUE NOT NULL,
    passwordHash NVARCHAR(255) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE() NOT NULL
);



CREATE TABLE QuestionsDaily (
    questionID INT PRIMARY KEY IDENTITY(1,1),
    questionText NVARCHAR(255) NOT NULL,
    category NVARCHAR(50) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE() NOT NULL
);


CREATE TABLE ResponsesDaily (
    responseID INT PRIMARY KEY IDENTITY(1,1),
    userID INT,
    questionID INT,
    responseDate DATE DEFAULT CAST(GETDATE() AS DATE) NOT NULL,
    score INT CHECK (score BETWEEN 1 AND 5),
    CONSTRAINT FK_User FOREIGN KEY (userID) REFERENCES Users(userID),
    CONSTRAINT FK_Question FOREIGN KEY (questionID) REFERENCES Questions(questionID),
    UNIQUE (userID, questionID, responseDate) -- Prevents duplicate answers per day
);

