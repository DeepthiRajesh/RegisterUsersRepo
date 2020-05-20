
export class AppSettings {

    public headerSettings: HeaderSettings

}
export class HeaderSettings {

    public tabs: Array<TabSettings>;
}

export class TabSettings {

    public title: string;
    public url: string
}
