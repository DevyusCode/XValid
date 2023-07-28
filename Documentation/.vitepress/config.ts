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
        text: "Examples",
        items: [
          { text: "Markdown Examples", link: "/markdown-examples" },
          { text: "Runtime API Examples", link: "/api-examples" },
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
