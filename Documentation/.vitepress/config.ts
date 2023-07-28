import { defineConfig } from "vitepress";

// https://vitepress.dev/reference/site-config
export default defineConfig({
  title: "XValid",
  description: "A simple C# validator library.",
  base: "/xvalid/",
  lastUpdated: true,
  outDir: "../dist",
  head: [["link", { rel: "icon", href: "/xvalid/logo.png" }]],
  themeConfig: {
    // https://vitepress.dev/reference/default-theme-config
    nav: [
      { text: "Home", link: "/" },
      { text: "Getting Started", link: "/get-started" },
      { text: "API Reference", link: "/ref" },
    ],
    editLink: {
      pattern:
        "https://github.com/Leo-Corporation/Synethia/edit/main/Documentation/:path",
      text: "Edit this page on GitHub",
    },
    sidebar: [
      {
        text: "Start",
        items: [
          { text: "Home", link: "/" },
          { text: "Getting Started", link: "/get-started" },
          { text: "Contribute", link: "/contribute" },
        ],
      },
      {
        text: "API Reference",
        items: [
          { text: "EmailValidator", link: "/api/email-validator" },
          { text: "ISBNValidator", link: "/api/isbn-validator" },
          { text: "IBANValidator", link: "/api/iban-validator" },
          { text: "CreditCardValidator", link: "/api/credit-card-validator" },
          { text: "IPAddressValidator", link: "/api/ip-address-validator" },
          { text: "CoordinateValidator", link: "/api/coordinate-validator" },
        ],
      },
    ],

    footer: {
      message: "Released under the MIT License.",
      copyright: "Copyright © 2023 Devyus",
    },
    socialLinks: [
      { icon: "github", link: "https://github.com/DevyusCode/XValid" },
      {
        icon: "twitter",
        link: "https://twitter.com/LeoCorpNews",
      },
      {
        icon: "youtube",
        link: "https://www.youtube.com/channel/UC283Dtf6EJ8eKfRoo0ISmqg",
      },
    ],
    outline: [1, 3],
  },
});
