export type ExtractedData = {
  name: string;
  label: string;
  value: string;
};

export type Document = {
  filename: string;
  url: string;
  tags: string[];
  fields: ExtractedData[];
};
