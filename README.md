# Twitch Live iRacing for iRacing Streamers

## Overview

This Windows Form app, built using .NET 8.0, is tailored for Twitch streamers focusing on iRacing content. It simplifies updating your Twitch stream title to reflect the current racing activity in a consistent and informative format.

## Features

- **Dynamic Title Formatting**: Automates Twitch stream title updates using the format: `[Type of Race (Qualy, Practice, or Race) with Strength of Field for the Season] - [Series Name]`.
- **Customizable Startup Options**: Choose to start the application with Windows, in a minimized state, or with standard launch.
- **Log Management**: Enable or disable logging for troubleshooting and record-keeping.

## Getting Started

### Prerequisites

- Windows operating system
- .NET 8.0 Runtime

### Installation

![Screenshot 2023-12-17 195813](https://github.com/chemitaxis/Twitch-Live-iRacing/assets/1420409/983212d3-0e49-4b35-8ac6-f4f5a6d57a75)

1. Download the latest release from the [GitHub releases page](#).
2. Unzip the downloaded file to your desired location.
3. Execute the application file to start.

### Configuration

First-time users will be prompted to set up:
- Twitch API credentials.
- Startup preferences.
- Logging options.

## Generating Twitch API Token

### Steps to Generate Twitch API Token

1. **Visit [Twitch Token Generator](https://twitchtokengenerator.com)**.
2. **Select Custom Scope Token**.
3. **Enable `channel:manage:broadcast` Scope**.
4. **Generate and Use the Token**: Follow the on-site instructions to generate your token. Use this in the application settings for API interaction.

**Note**: The client ID corresponds to the Twitch Token Generator application and should not be changed unless you're well-versed with the application's code.


## Usage

Once configured, the app automatically updates your Twitch stream title. Manual title overrides are possible through the app interface.

## Support

For issues or inquiries, please open an issue on the GitHub repository.

## Contributing

Contributions are welcome. To contribute, please fork the repository and submit a pull request.

## License

This project is licensed under the GNU General Public License
