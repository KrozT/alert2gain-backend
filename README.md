<!-- Improved compatibility of back to top link: See: https://github.com/othneildrew/Best-README-Template/pull/73 -->
<a name="readme-top"></a>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
<div align="center" markdown="1">

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

</div>

<!-- PROJECT LOGO -->
<br />
<div align="center">
   <a>
    <img src="https://i.imgur.com/jkRD5wK.png" alt="Logo" width="180" height="180">
  </a>

<h3 align="center">Alert2Gain</h3>

<div align="center">

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/b466fbb094ca4774a60180f6ec279a32)](https://app.codacy.com/gh/KrozT/alert2gain-backend/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)

</div>

  <p align="center">
An simple back-end project for Alert2Gain recluting process.
<br />
<a href="https://github.com/KrozT/alert2gain-backend"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/KrozT/alert2gain-backend/issues">Report Bug</a>
    ·
    <a href="https://github.com/KrozT/alert2gain-backend/pulls">Request Feature</a>
  </p>
</div>

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#screenshots">Screenshots</a></li>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>

## About The Project
### Screenshots
<details>

<summary>Images</summary>

[![A2G Back-End ScreenShot 1][product-screenshot-1]](https://github.com/KrozT/alert2gain-backend)

</details>

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

* [![.NET][.NET-shield]][.NET-url]
* [![C#][C#-shield]][C#-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/KrozT/alert2gain-backend.git
   ```
2. Add the necessary environment variables (Optional)
   ```dotenv
   # API URL
   A2G_API_URL=<YOUR API URL>
   
   # AUTH
   A2G_EMAIL=<YOUR EMAIL>
   A2G_PASSWORD=<YOUR PASSWORD>
   
   # SENSOR
   A2G_SENSOR_ID=<YOUR SENSOR ID> 
   ```
   This configuration is stored on environment variables for easy and fast deployment without having to change the code.
   If you don't want to use environment variables, no problem, just initialize the app and it will ask you for the necessary information.

3. Go to the project folder and build the project
   ```sh
   dotnet build
   ```


<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Once you have the project built and running on your preferred hosting service or locally,
just go to the address where you have it hosted or your localhost and you will be able to use it.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ROADMAP -->
## Roadmap

- [x] API Integration
  - [x] Login
  - [x] Data Fetching
  - [x] Results Sending
- [x] Noise detection
- [x] DateTime Normalization (UTC to Pacific Time)

See the [open issues](https://github.com/KrozT/alert2gain-backend/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* [Othneil Drew](https://github.com/othneildrew/)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/KrozT/alert2gain-backend.svg?style=for-the-badge
[contributors-url]: https://github.com/KrozT/alert2gain-backend/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/KrozT/alert2gain-backend.svg?style=for-the-badge
[forks-url]: https://github.com/KrozT/alert2gain-backend/network/members
[stars-shield]: https://img.shields.io/github/stars/KrozT/alert2gain-backend.svg?style=for-the-badge
[stars-url]: https://github.com/KrozT/alert2gain-backend/stargazers
[issues-shield]: https://img.shields.io/github/issues/KrozT/alert2gain-backend.svg?style=for-the-badge
[issues-url]: https://github.com/KrozT/alert2gain-backend/issues
[license-shield]: https://img.shields.io/github/license/KrozT/alert2gain-backend.svg?style=for-the-badge
[license-url]: https://github.com/KrozT/alert2gain-backend/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/matias-espinoza-bustos/
[product-screenshot-1]: https://i.imgur.com/XTPKz8I.png

[C#-shield]: https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white
[C#-url]: https://docs.microsoft.com/en-us/dotnet/csharp/

[.NET-shield]: https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white
[.NET-url]: https://dotnet.microsoft.com/