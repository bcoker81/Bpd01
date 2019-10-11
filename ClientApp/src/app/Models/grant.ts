export class Grant {
    id: number;
    grantNumber: number;
    grantName: string;
    status: string;
    division: string;
    projectStartDate: Date;
    projectEndDate: Date;
    financialReportDueDate: Date;
    programmingReportDueDate: Date;
    awardAmount: number;
    expenditures: number;
    remainingBalance: number;
    percentOfFundsSpent: number;
    match: number;
}
