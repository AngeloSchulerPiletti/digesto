export type EmailMessage = {
  id: string;
  author: {
    email: string;
    name: string;
  };
  subject: string;
  content: string;
  created_at: Date;
  updated_at: Date;
  read: boolean;
};
