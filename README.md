# Video Transcriber

Application application utilizing the SendBird API to implement a live chat room.

<img src='./assets/video.jpeg' width='100px' height='100px' /> <img src='./assets/arrow.png' width='100px' height='100px' /> <img src='./assets/text.png' width='100px' height='100px'/>


## LANGUAGE
- C#

## DATA PERSISTENCE
- Local Directory
    - Newly transcribed videos are saved as JSON files in a video-output directory
    - Directory will be created if it doesn't exist
    - File names are saved with a unique ID from the MS Video Indexer

## HOSTING
- local

## DEPLOYMENT
- in development stage

## CODE REPOSITORY
- GitHub { `you are here`}

## TOOLS
- C#
- .Net Project
- Azure Video Indexer


## GETTING STARTED

### Setup

- Clone this repo from your terminal

  `git clone https://github.com/sdmccoy/videoTrans.git`

- Create an account on Azure

  [Azure](https://azure.microsoft.com/en-us/ "Azure")

- Follow the 'get-started' steps on the Video Indexer SDK

  [Video Indexer SDK](https://videobreakdown.portal.azure-api.net/get-started "Video Indexer SDK")


- Import your API key to the second parameter on line 17
  - DO NOT hard code it and push it up.

  ```cs
  client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "PUT API KEY HERE");
  ```

- Import your video file path on line 20
  ```cs
  content.Add(new StreamContent(File.Open("PUT FILE PATH HERE", FileMode.Open)), "Video", "Video");
  ```
  
- To run the application, type this in your terminal

  `dotnet run`

- Watch your terminal for:
    - Video ID will log
  ```
  The video is uploading...
  Uploaded: 
  "60b812a5fe"
  ```
  - Video transcription retrieval progress
  ```
  State: 
  {"state":"Processing","progress":"30%"}
  ```
  - The full transcription in JSON
  ```
  Full JSON:
  "accountId":"ecb2b9 ..........."
  ```
-  Your project directory will create a new directory called 'video-ouput' with the new JSON file saved with a unique video ID

## TODO's

- API Keys
  - Import hidden API keys
- File Path
  - Pass in file path as argument
- Output
  - Create models for dynamic outputs
    - Language
    - Facial Recognition
    - Screen Text
    - Etc
