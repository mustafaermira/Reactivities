import { ReactNode } from "react";

export interface IActivity {
    category: ReactNode;
    id: string;
    title: string;
    description:string;
    date: string;
    city: string;
    venue: string;
}