/** @type {import('tailwindcss').Config} */
module.exports = {
    content: ["Components/**/*.{razor,html,cshtml}"],
    theme: {
        extend: {},
        fontFamily: {
            sans: ["JetBrains Mono", "monospace"],
        },
        colors: {
            "red-dim": {
                DEFAULT: "#cc2412",
                dark: "#cc2412",
            },
            red: {
                DEFAULT: "#9d0006",
                dark: "#fb4934",
            },
            "green-dim": {
                DEFAULT: "#98971a",
                dark: "#98971a",
            },
            green: {
                DEFAULT: "#79740e",
                dark: "#b8bb26",
            },
            "yellow-dim": {
                DEFAULT: "#d79921",
                dark: "#d79921",
            },
            yellow: {
                DEFAULT: "#b57614",
                dark: "#fabd2f",
            },
            "blue-dim": {
                DEFAULT: "#458598",
                dark: "#458588",
            },
            blue: {
                DEFAULT: "#076678",
                dark: "#83a598",
            },
            "purple-dim": {
                DEFAULT: "#b16286",
                dark: "#b16286",
            },
            purple: {
                DEFAULT: "#8f3f71",
                dark: "#d3869b",
            },
            "aqua-dim": {
                DEFAULT: "#689d6a",
                dark: "#689d6a",
            },
            aqua: {
                DEFAULT: "#427b58",
                dark: "#8ec07c",
            },
            "orange-dim": {
                DEFAULT: "#689d6a",
                dark: "#d65d0e",
            },
            orange: {
                DEFAULT: "#af3a03",
                dark: "#fe8019",
            },
            gray: {
                DEFAULT: "#928374",
                dark: "#928374",
            },
            "gray-dim": {
                DEFAULT: "#7c6f64",
                dark: "#a89984",
            },
            "bg-h": {
                DEFAULT: "#f9f5d7",
                dark: "#1d2021",
            },
            bg: {
                DEFAULT: "#fbf1c7",
                dark: "#282828",
            },
            "bg-1": {
                DEFAULT: "#ebdbb2",
                dark: "#3c3836",
            },
            "bg-2": {
                DEFAULT: "#d5c4a1",
                dark: "#504945",
            },
            "bg-3": {
                DEFAULT: "#bdae93",
                dark: "#665c54",
            },
            "bg-4": {
                DEFAULT: "#a89984",
                dark: "#7c6f64",
            },
            "bg-s": {
                DEFAULT: "#f2e5bc",
                dark: "#32302f",
            },
            "fg-4": {
                DEFAULT: "#7c6f64",
                dark: "#a89984",
            },
            "fg-3": {
                DEFAULT: "#665c54",
                dark: "#bdae93",
            },
            "fg-2": {
                DEFAULT: "#504945",
                dark: "#d5c4a1",
            },
            "fg-1": {
                DEFAULT: "#3c3836",
                dark: "#ebdbb2",
            },
            fg: {
                DEFAULT: "#282828",
                dark: "#fbf1c7",
            },
        },
    },
    plugins: [],
};
